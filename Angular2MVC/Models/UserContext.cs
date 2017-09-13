using System.Data.Entity;


namespace Angular2MVC.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("UsersDbConnection")
        {
        }

        public virtual DbSet<User> Users { get; set; }
    }
}