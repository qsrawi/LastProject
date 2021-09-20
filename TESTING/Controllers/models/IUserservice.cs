using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTING.Controllers.models
{
    public interface IUserservice
    {
        public List<Users> get();
        public Users get(int id);
        public void Post( Users user);
        public void Delete(int id);
    }
}
