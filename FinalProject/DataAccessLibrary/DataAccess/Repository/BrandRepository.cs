using DataAccessLibrary.DataAccess.Interface;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess.Repository
{
    public class BrandRepository : Repository<Brand>,IBrandRepository
    {
        public BrandRepository(NoheasApparelContext ctx) : base(ctx) 
        { }

        public NoheasApparelContext NoheasApparelContext
        {
            get { return Context as NoheasApparelContext; }
        }
    }
}
