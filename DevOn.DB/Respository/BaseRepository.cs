using DevOn.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevOn.Business.Interfaces;

namespace DevOn.DB.Respository
{
    public abstract class BaseRepository<T>: IBaseRepository<T> where T:class
    {
        protected readonly DevOnDbContext _devOnDbContext;
        public BaseRepository(DevOnDbContext devOnDbContext) {
            _devOnDbContext = devOnDbContext;
        }

        public void Add(T entity)
        {
           this._devOnDbContext.Add(entity);
        }

        public void Delete(T entity)
        {
            this._devOnDbContext.Remove(entity);
        }

        //public async  Task<T> Get(int Id)
        //{
        //    return await _devOnDbContext.Set<T>().FindAsync(Id);
        //}
        public abstract T Get(int Id);

        public IEnumerable<T> GetAll()
        {
            return _devOnDbContext.Set<T>().Select(x => x).Take(20);
        }

        public void SaveChanges()
        {
            _devOnDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _devOnDbContext.Update(entity);
        }
    }
}
