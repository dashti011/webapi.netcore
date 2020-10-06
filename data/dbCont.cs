using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestApi.data
{
    public class DbCont:DbContext
    {

        public DbCont(DbContextOptions<DbCont> options)
            : base(options)
        { }

        public DbSet<UserModelDb> Users { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Seed();
        }

       
    }
}
