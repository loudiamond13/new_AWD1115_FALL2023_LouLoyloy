using SportsPro.Models;
using SportsPro.Repositories.Interfaces;

namespace SportsPro.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(SportsProContext ctx): base(ctx) { }

        public SportsProContext SportsProContext
        {
            get { return Context as SportsProContext; }
        }
    }

    
    
}
