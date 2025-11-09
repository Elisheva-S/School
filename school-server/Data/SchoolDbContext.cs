using Microsoft.EntityFrameworkCore;
using School_Server.Models;
using System;

namespace School_Server.Data
{
	public class SchoolDbContext : DbContext
	{
		public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
		{
		}
		public DbSet<School> Schools { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Student> Students { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<School>()
		   .HasMany(s => s.Teachers)
		   .WithOne(t => t.School)
		   .HasForeignKey(p => p.SchoolId)
		   .OnDelete(DeleteBehavior.SetNull);
			modelBuilder.Entity<Teacher>()
			.HasMany(t => t.Students)
			.WithOne(s => s.Teacher)
			.HasForeignKey(t => t.TeacherId)
			.OnDelete(DeleteBehavior.SetNull);

		}
	}
}
