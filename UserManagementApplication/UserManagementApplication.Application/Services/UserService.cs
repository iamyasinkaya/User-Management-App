using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserManagementApplication.Application.Interfaces;
using UserManagementApplication.Application.Mapper;
using UserManagementApplication.Application.Models;
using UserManagementApplication.Core.Entities;
using UserManagementApplication.Core.Interfaces;

namespace UserManagementApplication.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public async Task<UserModel> CreateAsync(UserModel userModel)
        {

            var mappedEntity = MappingProfile.Mapper.Map<User>(userModel);
            var newEntity = await _userRepository.Create(mappedEntity);
            var newMappedEntity = MappingProfile.Mapper.Map<UserModel>(newEntity);

            return newMappedEntity;


        }

        public async Task<UserModel> DeleteAsync(UserModel userModel)
        {
            var mappedEntity = MappingProfile.Mapper.Map<User>(userModel);
            var newEntity = await _userRepository.Delete(mappedEntity.Id);
            var newMappedEntity = MappingProfile.Mapper.Map<UserModel>(newEntity);
            return newMappedEntity;
        }

        public async Task<IEnumerable<UserModel>> GetAll()
        {
            var userList = await _userRepository.GetAll();
            var mapped = MappingProfile.Mapper.Map<IEnumerable<UserModel>>(userList);
            return mapped;

        }

        public async Task<UserModel> GetByIdAsync(UserModel userModel)
        {
            var mappedEntity = MappingProfile.Mapper.Map<User>(userModel);
            var newEntity = await _userRepository.GetById(mappedEntity.Id);
            var newMappedEntity = MappingProfile.Mapper.Map<UserModel>(newEntity);

            return newMappedEntity;
        }

        public async Task<UserModel> UpdateAsync(UserModel userModel)
        {
            var mappedEntity = MappingProfile.Mapper.Map<User>(userModel);
            var newEntity = await _userRepository.Update(mappedEntity);
            var newMappedEntity = MappingProfile.Mapper.Map<UserModel>(newEntity);

            return newMappedEntity;
        }
    }
}
