using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTING.Controllers.models
{
    public class PostRepo : GenRepo<Post>, IPostRepo
    {
        private readonly AppDbContext _dbContext;
        public PostRepo(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
