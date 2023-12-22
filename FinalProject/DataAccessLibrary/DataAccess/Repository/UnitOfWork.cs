using DataAccessLibrary.DataAccess.Interface;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NoheasApparelContext context;
        public UnitOfWork(NoheasApparelContext ctx)
        {
            context = ctx;
            Products = new ProductRepository(context);
            Categories = new CategoryRepository(context);
            Brands = new BrandRepository(context);
            Genders = new GenderRepository(context);
        }

        public IProductRepository Products { get; private set; }
        public ICategoryRepository Categories { get; private set; }
        public IBrandRepository Brands { get; private set; }
        public IGenderRepository Genders { get; private set; }

        public void Update(object entity)
        {
            if (entity is Product)
            {
                context.Products.Update((Product)entity);
            }
            else if (entity is Category)
            {
                context.Categories.Update((Category)entity);
            }
            else if (entity is Brand)
            {
                context.Brands.Update((Brand)entity);
            }
            else if (entity is Gender)
            { 
                context.Genders.Update((Gender)entity);
            }
            
        }

        public int Complete()
        { 
            return context.SaveChanges();
        }

        public void Dispose()
        { 
            context?.Dispose();
        }

    }
}
