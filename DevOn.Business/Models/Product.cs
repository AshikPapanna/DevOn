using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.Business.Models
{
    public class Product:EntityBase
    {
       
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public Category Category{ get; set; }
         
    }
}
