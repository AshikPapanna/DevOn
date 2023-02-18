using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.Business.Models
{
    public class Category:EntityBase
    {
        
        public int CategoryID { get; set; }
        public  string Name { get; set; }
    }
}
