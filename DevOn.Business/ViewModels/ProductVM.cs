using DevOn.Business.Models;

namespace DevOn.API.ViewModels
{
    public class ProductVM
    {
        public int? ProductID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public string? CategoryName{ get; set; }

        public DateTime? Created { get; set; }
    }
}
