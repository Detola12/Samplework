using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sample.Models;

namespace sample.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set;}
        public DbSet<Car> Cars { get; set;}
        public DbSet<Transaction> Transactions { get; set;}
    }
}