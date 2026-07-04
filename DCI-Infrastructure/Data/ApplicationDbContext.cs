using Microsoft.EntityFrameworkCore;
using DCI_Domain.Entities;


namespace DCI_Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Consultation> Consultations => Set<Consultation>();
        public DbSet<MedicalHistory> MedicalHistories => Set<MedicalHistory>();
        public DbSet<Medication> Medications => Set<Medication>();
        public DbSet<Prescription> Prescriptions => Set<Prescription>();
        public DbSet<PrescriptionItem> PrescriptionItems => Set<PrescriptionItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Medication>().HasData(
                 new Medication { Id = 1, Name = "Paracétamol", Strength = "500 mg", Form = "Comprimé" },
                 new Medication { Id = 2, Name = "Amoxicilline", Strength = "1 g", Form = "Gélule" },
                 new Medication { Id = 3, Name = "Ibuprofène", Strength = "400 mg", Form = "Comprimé" },
                 new Medication { Id = 4, Name = "Metformine", Strength = "850 mg", Form = "Comprimé" },
                 new Medication { Id = 5, Name = "Oméprazole", Strength = "20 mg", Form = "Gélule" }
            );

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

