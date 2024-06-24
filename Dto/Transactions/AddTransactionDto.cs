using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.Dto.Transactions
{
    public class AddTransactionDto
    {
        public int CarId { get; set; } // CarId = 2
        public int UserId {get; set;} // userId = 1
    }
}