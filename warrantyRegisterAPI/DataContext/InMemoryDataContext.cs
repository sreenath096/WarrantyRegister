using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using warrantyRegisterAPI.Models.Entities;

namespace warrantyRegisterAPI.DataContext
{
    public class InMemoryDataContext : DbContext
    {
        public InMemoryDataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("WarrantyRegisterationDb");
        }
        public DbSet<WarrantyRegister> WarrantyRegisters { get; set; }
    }
}