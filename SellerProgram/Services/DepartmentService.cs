using Microsoft.EntityFrameworkCore;
using SellerProgram.Data;
using SellerProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellerProgram.Services
{
    public class DepartmentService
    {
        private readonly SellerProgramContext _context;

        public DepartmentService(SellerProgramContext context) 
        { 
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}
