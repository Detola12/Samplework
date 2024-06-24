using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sample.Data;
using sample.Dto.Users;
using sample.Interfaces;
using sample.Mappers;
using sample.Models;

namespace sample.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public User CreateUser(CreateUserDto createUserDto)
        {
            var userModel = createUserDto.ToUserModel();
            _context.Users.Add(userModel);
            _context.SaveChanges();

            return userModel;
        }

        public UserDto DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetAllUsers()
        {
            var users = _context.Users.Select(x => x.ToUserDtoFromModel()).ToList();
            return users;
        }

        public UserDto GetUserById(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            return user.ToUserDtoFromModel();
        }

        public UserDto UpdateUser(int id, UpdateUserDto updateUserDto)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);
            user.FirstName = updateUserDto.FirstName;
            user.LastName = updateUserDto.LastName;
            user.Email = updateUserDto.Email;
            user.Password = updateUserDto.Password;

            _context.SaveChanges();
            return user.ToUserDtoFromModel();
        }
    }
}