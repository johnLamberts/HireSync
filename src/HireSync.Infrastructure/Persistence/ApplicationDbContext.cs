
using System.Reflection;
using HireSync.Domain.Entities.IdentityUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HireSync.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicantUser, IdentityRole<int>, int> (options)
{
    public DbSet<Admin> Admins => Set<Admin>();


    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Admin>().ToTable("Admins");

      Console.WriteLine(builder.Entity<Admin>());

      builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

      base.OnModelCreating(builder);
    }
}
