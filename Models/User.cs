using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sample.Models
{
    [Index("Email", IsUnique = true)]
    public class User
    {
        public int Id { get; set;}
        [StringLength(30)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(30)]
        public string LastName { get; set; } = string.Empty;
        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
        [StringLength(20)]
        public string Password { get; set; } = string.Empty;
    }
}