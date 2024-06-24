using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sample.Dto.Transactions;
using sample.Models;

namespace sample.Mappers
{
    public static class TransactionMapper
    {
        public static Transaction ToModel(this AddTransactionDto transactionDto){
            return new Transaction{
                CarId = transactionDto.CarId,
                UserId = transactionDto.UserId,
            };
        }
    }
}