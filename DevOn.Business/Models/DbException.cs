using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.DB.Common
{
    [Serializable]
    public class ValidationException:Exception
    {
  
        public ValidationException(string m):base(m) {
          
        }
    }
}
