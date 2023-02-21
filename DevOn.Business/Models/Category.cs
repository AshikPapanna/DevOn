using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.Business.Models
{
    [Index(nameof(Name),IsUnique=true)]
    public class Category:EntityBase
    {
        
        public int CategoryID { get; set; }
        [MaxLength(50)]
        public  string Name { get; set; }
    }
}
