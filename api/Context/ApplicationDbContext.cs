using Api.Models;

using API.Models;

using Microsoft.EntityFrameworkCore;

namespace API.Context;

#nullable disable

public class ApplicationDbContext : DbContext
{ 
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

	public DbSet<User> UserRegistrations { get; set; }

	public DbSet<TrainingProgram> TrainingPrograms { get; set; }

	public DbSet<Trainer> Trainer { get; set; }

	public DbSet<Membership> Membership { get; set; }

	public DbSet<Role> Roles { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Role>().HasData(
				new Role
				{
					roleId = 1,
					roleName = "Admin"
				},

				new Role
				{
					roleId = 2,
					roleName = "User"
				});
	}


}
