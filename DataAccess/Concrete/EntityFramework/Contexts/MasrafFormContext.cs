using Core.Entities.Concrete;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class MasrafFormContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-UJJUC08M;Database=MasrafForm;Trusted_Connection=true");
        }

        public DbSet<Fis> Fisler { get; set; }
        public DbSet<Makbuz> Makbuzlar { get; set; }

        //SONRA YAPILACAKLAR 
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
