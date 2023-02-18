using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOn.Business.Interfaces
{
    public interface IBaseRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(int Id);
        IEnumerable<T> GetAll();
        void SaveChanges();
    }
}
