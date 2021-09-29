using AutoMapper;
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
        private readonly IMapper _mapper;
        public PostController(IMapper mapper)
        {
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPost()
        {
            Post p = new Post();
            var UVM = _mapper.Map<PostViewModel>(p);
            return Ok(UVM);
        }
    }
}
