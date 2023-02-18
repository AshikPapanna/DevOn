using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.Business.Models
{
    public class EntityBase
    {
        public EntityBase() {
        }
       
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
