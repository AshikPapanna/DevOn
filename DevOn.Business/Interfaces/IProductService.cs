using DevOn.API.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace DevOn.API.Interfaces
{
    public interface IProductService
    {
        void AddProduct(ProductVM pro);
        IEnumerable<ProductVM> GetAllProducts();
        void DeleteProduct(int id);
        ValidationResult Validate(ProductVM p);
    }
}
