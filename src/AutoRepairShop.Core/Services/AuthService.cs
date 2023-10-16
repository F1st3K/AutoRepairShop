﻿using AutoRepairShop.Core.dtos;
using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Entity;
using AutoRepairShop.Core.Repositories;

namespace AutoRepairShop.Core.Services
{
    class AuthService<TUserRepository, TUserInfoRepository>
        where TUserRepository : IRepository<User>, IUniqNameRepository<User>
        where TUserInfoRepository : IRepository<UserInfo>
    {
        private TUserRepository _userRepository;
        private TUserInfoRepository _userInfoRepository;
        private HashService _hashService;

        public AuthService(TUserRepository userRepository, TUserInfoRepository userInfoRepository)
        {
            _userRepository = userRepository;
            _userInfoRepository = userInfoRepository;
            _hashService = new HashService();
        }

        public bool TrySignIn(AuthDto dto)
        {
            if (_userRepository.TryGetId(dto.Login, out var id) == false ||
                _userRepository.TryGet(id, out var user) == false)
                return false;
            return user.Hash == _hashService.Hash(dto.Password);
        }

        public bool TrySignUp(RegDto dto)
        {
            if (_userRepository.IsUniq(dto.UniqName) == false)
                return false;
            var userInfo = new UserInfo
            {
                Name = dto.Name,
                Surname = dto.Surname,
                Patronomic = dto.Patronomic,
                DOB = dto.DOB,
                Phone = dto.Phone
            };
            var id = _userInfoRepository.Add(userInfo);

            var user = new User
            {
                UniqName = dto.UniqName,
                Hash = _hashService.Hash(dto.Password),
                InfoId = id,
                RoleId = dto.RoleId
            };
            _userRepository.Add(user);
            return true;
        }
    }
}
