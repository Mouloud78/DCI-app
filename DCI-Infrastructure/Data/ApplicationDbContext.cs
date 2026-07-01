using DCI_Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DCI_Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients => Set<Patient>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(p => p.FirstName)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(p => p.LastName)
                      .HasMaxLength(100)
                      .IsRequired();

                entity.Property(p => p.Phone)
                      .HasMaxLength(20);

                entity.Property(p => p.Email)
                      .HasMaxLength(150);

                entity.Property(p => p.Address)
                      .HasMaxLength(250);

                entity.Property(p => p.BloodGroup)
                      .HasMaxLength(5);
            });
        }
    }
}

