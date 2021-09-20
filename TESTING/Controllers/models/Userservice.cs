using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTING.Controllers.models
{

   
    public class Userservice : IUserservice
    {
        List<Users> listofusers = new List<models.Users>
        {
            new Users(1,"oday","059574","ooo",DateTime.Now),
            new Users(2,"uu","059574","ooao", DateTime.Now),
           new Users(3,"oday","059574","ooo", DateTime.Now),
        new Users(4,"oday","059574","ooo", DateTime.Now),
        new Users(5,"oday","059574","ooo", DateTime.Now)

             };
       /// <summary>
       /// delete [http post and get and delete]
       /// </summary>
       
        public void Delete(int id)
        {
            var z = listofusers.FirstOrDefault(i => i.Id==id);
            listofusers.Remove(z);
        }
       
        public List<Users> get()
        {
            return listofusers;
        }
       
        public Users get(int id)
        {
            return listofusers.FirstOrDefault(i => i.Id == id);
        }
       
        public void Post(Users user)
        {
            listofusers.Add(user);
        }
    }
}
