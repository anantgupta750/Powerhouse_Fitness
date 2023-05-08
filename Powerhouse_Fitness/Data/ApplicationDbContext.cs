using Microsoft.EntityFrameworkCore;
using Powerhouse_Fitness.Models;
using System.Runtime.InteropServices;

namespace Powerhouse_Fitness.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<UserRegistration> User_Registration { get; set; }
        public DbSet<Models.Programs> Program { get; set; }
        public DbSet<Trainer> Trainer { get; set; }
        public DbSet<Membership> Membership { get; set; }   


    }
}
