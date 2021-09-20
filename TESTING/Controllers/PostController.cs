using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTING.Controllers.models;

namespace TESTING.Controllers
{
    public class PostController : Controller
    {
        IPostRepo userrepo = null;



        /*public List<Users> users { get; set; } = new List<Users>()
        {
            new Users(){},
            new Users()
        };*/
        public PostController(IPostRepo userrepo)
        {

            this.userrepo = userrepo;
        }
        [HttpGet]
        public IEnumerable<Post> GetAll()
        {
            return userrepo.get();
        }
        [HttpGet("{id}")]
        public Post get(int id)
        {
            return userrepo.get(id);
        }

        [HttpPost]
        public void Post(Post t)
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
