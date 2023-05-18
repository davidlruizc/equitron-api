using Core.Users.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework
{
    public partial class EquitronContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public EquitronContext() { }
    }
}
