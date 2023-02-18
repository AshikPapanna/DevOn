using DevOn.Business.Interfaces;
using DevOn.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.DB.Respository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DevOnDbContext devOnDbContext) : base(devOnDbContext)
        {
        }

        public override Product Get(int Id)
        {
            return _devOnDbContext.Products.Where(x => x.ProductID == Id).First();
        }
    }
}
