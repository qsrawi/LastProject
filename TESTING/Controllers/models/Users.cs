using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTING.Controllers.models
{
    public class Users:IBaseModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public DateTime Dop { get; set; }
        public int Age { get; set; }
        public ICollection<Post>posts { get; set; }
        public ICollection<Post> Rposts { get; set; }
        public Users()
        {

        }

        public Users(int id, string name, string phone, string email, DateTime dop )
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Dop = dop;
        }

       
      
    }
}
