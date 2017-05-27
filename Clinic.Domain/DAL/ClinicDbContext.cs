namespace Clinic.Domain.DAL
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Clinic.Domain.Model;

    public partial class ClinicDbContext : DbContext, IClinicDbContext
    {
        public ClinicDbContext(DbContextOptions<ClinicDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessRight> AccessRight { get; set; }
        public virtual DbSet<Analisis> Analisis { get; set; }
        public virtual DbSet<AnalisisKind> AnalisisKind { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<MedicalCard> MedicalCard { get; set; }
        public virtual DbSet<MedicalCardRecord> MedicalCardRecord { get; set; }
        public virtual DbSet<MedicalDetails> MedicalDetails { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<OnlineConsultation> OnlineConsultation { get; set; }
        public virtual DbSet<OnlineConsultationMessage> OnlineConsultationMessage { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }
        public virtual DbSet<WorkerKind> WorkerKind { get; set; }
    }
}
