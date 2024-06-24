using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sample.Dto.Users;
using sample.Models;

namespace sample.Interfaces
{
    public interface IUserRepository
    {
        public List<UserDto> GetAllUsers();
        public UserDto GetUserById(int id);
        public User CreateUser(CreateUserDto createUserDto);
        public UserDto UpdateUser(int id, UpdateUserDto updateUserDto);
        public UserDto DeleteUser(int id);
    }
}