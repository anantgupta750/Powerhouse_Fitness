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
        public DbSet<user_registeration> User_Registration { get; set; }
        public DbSet<Models.Program> Program { get; set; }
        public DbSet<trainer> Trainer { get; set; }
        public DbSet<membership> Membership { get; set; }   


    }
}
