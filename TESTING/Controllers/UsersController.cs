using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTING.Controllers.models;

namespace TESTING.Controllers
{
    [ApiController]
    ///Use api at URL
    [Route("api/[controller]")]
    ///rename user controller
    public class UsersController : ControllerBase
    {


        IUserRepo userrepo = null;



        /*public List<Users> users { get; set; } = new List<Users>()
        {
            new Users(){},
            new Users()
        };*/
        public UsersController(IUserRepo userrepo)
        {

            this.userrepo = userrepo;
        }
        [HttpGet]
        public IEnumerable<Users> GetAll()
        {
            return userrepo.get();
        }
        [HttpGet("{id}")]
        public Users get(int id)
        {
            return userrepo.get(id);
        }

        [HttpPost]
        public void Post(Users t)
        {
            userrepo.Post(t);
        }
        


        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            userrepo.Delete(id);

        }

    }
}
