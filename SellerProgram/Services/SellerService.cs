using System.Collections.Generic;
using System;
using SellerProgram.Data;
using SellerProgram.Models;
using System.Linq;

namespace SellerProgram.Services
{
    public class SellerService
    {
        private readonly SellerProgramContext _context;
        public SellerService(SellerProgramContext context)
        { 
            _context = context;
        }

        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }

    }
}
