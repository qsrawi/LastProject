using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TESTING.Controllers.models;
using AutoMapper;
namespace TESTING.Controllers
{
    [ApiController]
    ///Use api at URL
    [Route("api/[controller]")]
    ///rename user controller
    public class UsersController : ControllerBase
    {

        private readonly IMapper _mapper;
        IUserRepo userrepo = null;

        public UsersController(IMapper mapper, IUserRepo userrepo)
        {
            this._mapper = mapper;
            this.userrepo = userrepo;

        }

        [HttpGet]
        public IActionResult GetIdAndName()
        {
            Users user = new Users();
            var UVM = _mapper.Map<UserViewModel>(user);
            return Ok(UVM);
        }
        [HttpGet("{size}/{index}")]
        public IEnumerable<Users> GetAll(int size,int index)
        {
            return userrepo.get(size, index);
        }
        [HttpGet("{id}")]
        public Users GetUserWithPost(int id)
        {
            return userrepo.GetUserWithPost(id);
        }
    }
}
