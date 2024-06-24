using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sample.Dto.Users;
using sample.Models;

namespace sample.Mappers
{
    public static class UserMapper
    {
        public static User ToUserModel(this CreateUserDto createUserDto){
            return new User{
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName,
                Email = createUserDto.Email,
                Password = createUserDto.Password,
            };
        }

        public static UserDto ToUserDtoFromModel(this User user){
            return new UserDto {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
            };
        }
    }
}