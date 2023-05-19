using Core.Users.Domain.Model;
using Core.Users.Domain.Services;
using Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Exceptions;
using Utilities.Repository;

namespace Infrastructure.Repositories
{
    public class UsersRepository : EntityFrameworkRepository<EquitronContext>, IUsersRepository
    {
        public UsersRepository(EquitronContext dbContext) : base(dbContext)
        {
        }

        public IList<Users> GetUsers()
        {
            return dbContext.Users.ToList();
        }

        public Users GetUser(Guid id)
        {
            return dbContext.Users.Where(u => u.Id == id).FirstOrDefault() ?? throw new CustomException("User not found");
        }
    }
}
