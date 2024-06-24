using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int CarId { get; set; } // CarId = 2
        public int UserId {get; set;} // userId = 1
        [ForeignKey("CarId")]
        public Car? Car{ get; set; }
        [ForeignKey("UserId")]
        public User? User{ get; set; }
    }
}