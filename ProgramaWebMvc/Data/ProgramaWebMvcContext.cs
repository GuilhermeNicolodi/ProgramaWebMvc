using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProgramaWebMvc.Models;

namespace ProgramaWebMvc.Data
{
    public class ProgramaWebMvcContext : DbContext
    {
        public ProgramaWebMvcContext (DbContextOptions<ProgramaWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
