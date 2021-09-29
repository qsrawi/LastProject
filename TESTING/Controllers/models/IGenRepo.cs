using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTING.Controllers.models
{
    public interface IGenRepo<T> where T:class,IBaseModel
    {
        public IEnumerable<T> get(int size, int index);
        
    }
}
