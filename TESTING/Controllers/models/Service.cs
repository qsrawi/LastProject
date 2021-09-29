
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace TESTING.Controllers.models
{
    public static class Service
    {
        public static void AddService(this IServiceCollection service , IConfiguration configuration)
        {
            service.AddScoped<IUserRepo, UserRepo>();
            service.AddScoped<IPostRepo, PostRepo>();
            service.AddControllers();
            service.AddSwaggerGen();
            service.AddAutoMapper(typeof(Startup));
            service.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
