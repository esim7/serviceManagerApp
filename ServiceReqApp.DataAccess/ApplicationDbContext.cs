using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiceReqApp.Domain;

namespace ServiceReqApp.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Request> Requests { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}