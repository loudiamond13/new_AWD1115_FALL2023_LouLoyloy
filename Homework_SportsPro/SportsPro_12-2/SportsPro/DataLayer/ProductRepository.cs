using SportsPro.DataLayer.Interfaces;
using SportsPro.Models;

namespace SportsPro.DataLayer
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(SportsProContext ctx) : base(ctx) { }

        public SportsProContext SportsProContext
        {
            get { return Context as SportsProContext; }
        }
    }



}
