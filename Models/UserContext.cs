using Microsoft.EntityFrameworkCore;

namespace GoRestUsers.Models
{
    public class UserContext:DbContext
    {
        public DbSet<UserInfo> Users { get; set; }

        public UserContext(DbContextOptions options):base(options) 
        {
            
        }
    }
}
