using System;

namespace SellerProgram.Services.Exceptions
{
    public class DbConcurrencyException : Exception
    {   
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
