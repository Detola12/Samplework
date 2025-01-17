using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Dto.Users
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set;} = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}