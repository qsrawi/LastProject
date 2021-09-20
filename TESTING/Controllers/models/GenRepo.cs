using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTING.Controllers.models
{
    public class GenRepo<T> : IGenRepo<T> where T : class,IBaseModel
    { 
        private readonly AppDbContext _dbContext;

        public GenRepo(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }


        public void Delete(int id)
        {
            var choosen = _dbContext.users.SingleOrDefault(item => item.Id == id);
            _dbContext.users.Remove(choosen);
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> get()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T get(int id)
        {
            return _dbContext.Set<T>().SingleOrDefault(item => item.Id == id);
        }

        public void Post(T t)
        {
            _dbContext.Set<T>().Add(t);
            _dbContext.SaveChanges();
        }
    }
}
