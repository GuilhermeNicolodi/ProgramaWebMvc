using ProgramaWebMvc.Data;
using ProgramaWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramaWebMvc.Services
{
    public class SellerService
    {
        private readonly ProgramaWebMvcContext _context;

        public  SellerService(ProgramaWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
