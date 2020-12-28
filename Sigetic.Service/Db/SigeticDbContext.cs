using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sigetic.Service.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sigetic.Service.Db
{
    public class SigeticDbContext : IdentityDbContext<AppUser> 
    {
        public SigeticDbContext(DbContextOptions<SigeticDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<JiraIssue> JiraIssue { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<JiraIssue>(entity =>
            {
                entity.ToView("JiraIssueView");
                entity.HasNoKey();
            });
            builder.Entity<AppUser>(entity =>
            {
                entity.Property(x => x.FirstName).HasMaxLength(30);
                entity.Property(x => x.LastName).HasMaxLength(30);
            });
        }
    }
}
