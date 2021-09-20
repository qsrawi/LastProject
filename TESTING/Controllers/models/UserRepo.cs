using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TESTING.Controllers.models
{
    public class UserRepo : GenRepo<Users>,IUserRepo
    {
        private readonly AppDbContext _dbContext;
        public UserRepo(AppDbContext dbContext) : base(dbContext)
        {
           _dbContext = dbContext;
        }
    }
}
