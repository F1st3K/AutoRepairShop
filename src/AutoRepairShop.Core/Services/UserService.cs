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

        public UserFull GetUser(int id)
        {
            _userRepository.TryGet(id, out var user);
            _userInfoRepository.TryGet(user.InfoId, out var userInfo);
            return new UserFull
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

        public void EditUser(UserFull user)
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
            var u = new User
            {
                Id = 0,
                UniqName = user.Login,
                Hash = user.Hash,
                InfoId = user.Id,
                RoleId = user.Role
            };

            _userInfoRepository.Edit(ui);

            if (_userRepository.TryGetId(user.Login, out var id))
            {
                if (user.Role == 0)
                {
                    _userRepository.Delete(id);
                    return;
                }
                u.Id = id;
                _userRepository.Edit(u);
            }
            else
            {
                _userRepository.Add(u);
            }

        }

        public void CreateUser(UserFull user)
        {
            var ui = new UserInfo
            {
                Id = 0,
                Name = user.Name,
                Surname = user.Surname,
                Patronomic = user.Patronomic,
                DOB = user.DateOfBirth,
                Phone = user.Phone,
            };
            
            int id = _userInfoRepository.Add(ui);
            var u = new User
            {
                Id = 0,
                UniqName = user.Login,
                Hash = user.Hash,
                InfoId = id,
                RoleId = user.Role
            };
            if (user.Role != 0)
                _userRepository.Add(u);
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
