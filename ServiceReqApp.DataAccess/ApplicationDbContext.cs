﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiceReqApp.Domain;

namespace ServiceReqApp.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<User> /*DbContext*/
    {
        public DbSet<Request> Requests { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
                .HasOne(e => e.Employee)
                .WithOne(e => e.User)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Request>()
                .HasOne(p => p.Employee)
                .WithMany(t => t.Requests)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}