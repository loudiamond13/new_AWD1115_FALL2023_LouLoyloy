using DataAccessLibrary.DataAccess.Interface;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(NoheasApparelContext ctx) : base(ctx){ }

        public NoheasApparelContext NoheasApparelContext
        {
            get { return Context as NoheasApparelContext; }
        }

        public IEnumerable<Product> GetAllProducts()
        { 
            return NoheasApparelContext.Products.ToList();
        }
    }
}
