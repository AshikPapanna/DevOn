using DevOn.Business.Interfaces;
using DevOn.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.Business.Services
{
    public class CategoryService: ICategoryService
    {
        public readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository) {
            _categoryRepository = categoryRepository; }
        public IEnumerable<CategoryVM> GetAllCategory()
        {
            return _categoryRepository.GetAll().Select(x => new CategoryVM
            {
                ID = x.CategoryID,
                Name = x.Name
            });
        }

    }
}
