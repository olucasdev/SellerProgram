using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SellerProgram.Models;

namespace SellerProgram.Data
{
    public class SellerProgramContext : DbContext
    {
        public SellerProgramContext (DbContextOptions<SellerProgramContext> options)
            : base(options)
        {
        }

        public DbSet<SellerProgram.Models.Department> Department { get; set; }
    }
}
