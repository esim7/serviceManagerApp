using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiceReqApp.Domain;

namespace ServiceReqApp.DataAccess
{
    public class ApplicationDbContext : /*IdentityDbContext<User>*/ DbContext
    {
        public DbSet<Request> Requests { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<User>()
        //        .HasOne(a => a.Employee)
        //        .WithOne(b => b.User)
        //        .HasForeignKey<Employee>(b => b.UserId);

        //    builder.Entity<User>()
        //        .HasOne(a => a.UserProfile)
        //        .WithOne(b => b.User)
        //        .HasForeignKey<Employee>(b => b.UserId);
        //}
    }
}