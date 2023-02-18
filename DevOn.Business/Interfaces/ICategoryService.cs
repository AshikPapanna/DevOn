using DevOn.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.Business.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryVM> GetAllCategory();
    }
}
