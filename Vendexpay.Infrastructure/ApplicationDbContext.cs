using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vendexpay.Model;
using Vendexpay.Model.LookUps;

namespace Vendexpay.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public int CurrentUserId { get; set; }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<BuildingType> BuildingTypes { get; set; }
        public DbSet<Marchant> Marchants { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().HasMany(u => u.Claims).WithOne().HasForeignKey(c => c.UserId).IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.Entity<ApplicationUser>().HasMany(u => u.Roles).WithOne().HasForeignKey(r => r.UserId).IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ApplicationRole>().HasMany(r => r.Claims).WithOne().HasForeignKey(c => c.RoleId).IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.Entity<ApplicationRole>().HasMany(r => r.Users).WithOne().HasForeignKey(r => r.RoleId).IsRequired().OnDelete(DeleteBehavior.Cascade);

        }




        public override int SaveChanges()
        {
            UpdateAuditEntities();
            return base.SaveChanges();
        }


        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            UpdateAuditEntities();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }


        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditEntities();
            return base.SaveChangesAsync(cancellationToken);
        }


        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateAuditEntities();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }


        private void UpdateAuditEntities()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));


            foreach (var entry in modifiedEntries)
            {
                var entity = (BaseEntity)entry.Entity;
                DateTime now = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entity.createdDate = now;
                    entity.createdBy = CurrentUserId;
                }
                else
                {
                    base.Entry(entity).Property(x => x.createdBy).IsModified = false;
                    base.Entry(entity).Property(x => x.createdDate).IsModified = false;
                }

                entity.modefiedDate = now;
                entity.modefiedBy = CurrentUserId;
            }
        }
    }
}
