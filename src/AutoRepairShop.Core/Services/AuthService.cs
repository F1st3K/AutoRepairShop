using AutoRepairShop.Core.Entity;
using AutoRepairShop.Core.Repositories;
using System;

namespace AutoRepairShop.Core.Services
{
    class AuthService<TUserRepository>
        where TUserRepository : IRepository<User>
    {
        private IRepository<User> _userRepository;
        private HashService _hashService;

        public AuthService(TUserRepository userRepository)
        {
            _userRepository = userRepository;
            _hashService = new HashService();
        }


    }
}
