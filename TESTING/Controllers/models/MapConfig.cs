using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace TESTING.Controllers.models
{
    public class MapConfig:Profile
    {

        public MapConfig()
        {
            CreateMap<Users, UserViewModel>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();
        }
    }
}
