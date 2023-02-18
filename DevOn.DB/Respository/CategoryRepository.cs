using DevOn.Business.Interfaces;
using DevOn.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.DB.Respository
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DevOnDbContext devOnDbContext) : base(devOnDbContext)
        {
        }

        public override Category Get(int Id)
        {
            return _devOnDbContext.Categories.Where(x => x.CategoryID == Id).First();
        }
    }
}
