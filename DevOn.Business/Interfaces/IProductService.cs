using DevOn.API.ViewModels;

namespace DevOn.API.Interfaces
{
    public interface IProductService
    {
        void AddProduct(ProductVM pro);
        IEnumerable<ProductVM> GetAllProducts();
        void DeleteProduct(int id);
    }
}
