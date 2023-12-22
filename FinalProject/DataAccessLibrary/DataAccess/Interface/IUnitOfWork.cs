using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataAccess.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        IBrandRepository Brands { get; }
        IGenderRepository Genders { get; }


        void Update(object obj);
        int Complete();
    }
}
