using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Context
{
    public class UserContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions options) : base(options)
        {
            
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string Email { get; set; }
        public string Guid { get; set; }
        public bool IsActivated { get; set; }


    }

}
