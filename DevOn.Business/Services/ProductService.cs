using DevOn.API.Interfaces;
using DevOn.API.ViewModels;
using DevOn.Business.Interfaces;
using DevOn.Business.Models;


namespace DevOn.Business.Services
{

    public class ProductService: IProductService

    {
        public readonly IProductRepository _productRepository;
        public readonly ICategoryRepository _categoryRepository;
        public ProductService(IProductRepository productRepository,ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IEnumerable<ProductVM> GetAllProducts()
        {
            return from p in _productRepository.GetAll()
                   join c in _categoryRepository.GetAll()
                   on p.CategoryID equals c.CategoryID
                   select new ProductVM
                   {
                       ProductID = p.ProductID,
                       CategoryID = c.CategoryID,
                       CategoryName = c.Name,
                       Description = p.Description,
                       Quantity = p.Quantity,
                       Name = p.Name,
                       Created=p.Created
                   };
        }
        public void AddProduct(ProductVM pro) {
            var product = new Product()
            {
                Name = pro.Name,
                CategoryID = pro.CategoryID,
                Description = pro.Description,
                Quantity = pro.Quantity,
                Created=DateTime.Now

            };
            _productRepository.Add(product);
            _productRepository.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product=_productRepository.Get(id);
            _productRepository.Delete(product);
            _productRepository.SaveChanges();
        }
    }
}
