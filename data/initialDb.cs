using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestApi.data
{
    public static class InitialDb
    {
        
        public static void Seed(this ModelBuilder modelBuilder )
        {
            
             modelBuilder.Entity<UserModelDb>().HasData(
                 new UserModelDb() {Id = 1,Age = 25, Name = "Lima" },
                 new UserModelDb() {Id=2,Age = 30, Name = "Hassan" },
                 new UserModelDb() {Id = 3,Age = 31, Name = "iliya" }
                 
             );

        }
    }
}
