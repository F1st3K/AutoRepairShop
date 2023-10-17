using AutoRepairShop.Core.dtos;
using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Repositories;

namespace AutoRepairShop.Core.Services
{
    public class UserService<TUserRepository, TUserInfoRepository>
        where TUserRepository : IRepository<User>, IUniqNameRepository<User>
        where TUserInfoRepository : IRepository<UserInfo>
    {
        private TUserRepository _userRepository;
        private TUserInfoRepository _userInfoRepository;

        public UserService(TUserRepository userRepository, TUserInfoRepository userInfoRepository)
        {
            _userRepository = userRepository;
            _userInfoRepository = userInfoRepository;
        }

        public UserDto GetUser(int id)
        {
            _userRepository.TryGet(id, out var user);
            _userInfoRepository.TryGet(user.InfoId, out var userInfo);
            return new UserDto
            {
                Id = userInfo.Id,
                Name = userInfo.Name,
                Surname = userInfo.Surname,
                Patronomic = userInfo.Patronomic,
                DateOfBirth = userInfo.DOB,
                Phone = userInfo.Phone,
                Role = user.RoleId,
                Login = user.UniqName,
                Hash = user.Hash,
            };
        }

        public void EditUser(UserDto user)
        {
            var ui = new UserInfo
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Patronomic = user.Patronomic,
                DOB = user.DateOfBirth,
                Phone = user.Phone,
            };
            _userInfoRepository.Edit(ui);
            if (_userRepository.TryGetId(user.Login, out var id))
            {
                var u = new User
                {
                    Id = id,
                    UniqName = user.Login,
                    Hash = user.Hash,
                    InfoId = user.Id,
                    RoleId = user.Role
                };
                _userRepository.Edit(u);
            }

        }

        public void DeleteUser(int id, string uname)
        {
            if (_userInfoRepository.TryGet(id, out var ui))
                _userInfoRepository.Delete(id);
            if (_userRepository.TryGetId(uname, out var uid))
                _userRepository.Delete(uid);
        }
    }
}
