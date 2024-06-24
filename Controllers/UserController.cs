using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sample.Dto.Users;
using sample.Interfaces;
using sample.Mappers;

namespace sample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository repository;

        public UserController(IUserRepository userRepository)
        {
            repository = userRepository;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] CreateUserDto userDto){
            var user = repository.CreateUser(userDto);
            return Ok(user.ToUserDtoFromModel());
        }

        [HttpGet]
        public IActionResult GetAllUsers(){
            var user = repository.GetAllUsers();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id){
            var user = repository.GetUserById(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] int id, [FromBody] UpdateUserDto userDto){
            var user = repository.UpdateUser(id, userDto);
            return Ok(user);
        }
    }
}