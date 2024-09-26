using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgramaWebMvc.Models;

namespace ProgramaWebMvc.Data
{
    public class SeedingService
    {
        private ProgramaWebMvcContext _context;

        public SeedingService(ProgramaWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.SalesRecords.Any() ||
                _context.Seller.Any())
            {
                return;  // Dados ja estao no banco de dados
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Roupas");
            Department d3 = new Department(3, "Importado");
            Department d4 = new Department(4, "Variedades");

            Seller s1 = new Seller(1, "Gustavo", "gustavo@hotmail.com", new DateTime(2018, 3, 21), 1000.0, d3);
            Seller s2 = new Seller(2, "Guilherme", "guilherme@hotmail.com", new DateTime(2012, 4, 22), 1203.0, d1);
            Seller s3 = new Seller(3, "Bene", "bene@hotmail.com", new DateTime(2019, 1, 22), 1262.0, d4);
            Seller s4 = new Seller(4, "Marcia", "marcia@hotmail.com", new DateTime(1827, 12, 11), 16263.0, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2019, 02, 1), 12563.0, Models.Enums.SaleStatus.Pending);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2019, 02, 11), 12123.0, Models.Enums.SaleStatus.Pending);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2029, 02, 13), 12563.0, Models.Enums.SaleStatus.Canceled);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2014, 02, 23), 563.0, Models.Enums.SaleStatus.Billed);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2014, 01, 17), 128263.0, Models.Enums.SaleStatus.Billed);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4);
            _context.SalesRecords.AddRange(sr1, sr2, sr3, sr4, sr5);

            _context.SaveChanges();

        }
    }
}
