using API.Models;

using Microsoft.EntityFrameworkCore;

namespace API.Context;

#nullable disable

public class ApplicationDbContext : DbContext
{
	public DbSet<User> UserRegistrations { get; set; }

	public DbSet<TrainingProgram> TrainingPrograms { get; set; }

	public DbSet<Trainer> Trainer { get; set; }

	public DbSet<Membership> Membership { get; set; }

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}
