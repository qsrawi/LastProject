using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace TESTING.Controllers.models
{
    public class GenRepo<T> : IGenRepo<T> where T : class,IBaseModel
    { 
        private readonly AppDbContext _dbContext;

        public GenRepo(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public IEnumerable<T> get(int size,int index)
        {
            return _dbContext.Set<T>().Take(size).ToList().Skip(size * (index - 1));
        }

      
    }
}
