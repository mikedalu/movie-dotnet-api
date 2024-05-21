using Microsoft.EntityFrameworkCore;



namespace movie_dotnet_api.Model
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options): base (options)
        {
        }
        public DbSet<User> Users { get; set; }

    }
}
