namespace Clinic.Domain.DAL
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Clinic.Domain.Model;

    public interface IClinicDbContext : IDbContext
    {

        DbSet<AccessRight> AccessRight { get; set; }
        DbSet<Analisis> Analisis { get; set; }
        DbSet<AnalisisKind> AnalisisKind { get; set; }
        DbSet<Appointment> Appointment { get; set; }
        DbSet<Document> Document { get; set; }
        DbSet<MedicalCard> MedicalCard { get; set; }
        DbSet<MedicalCardRecord> MedicalCardRecord { get; set; }
        DbSet<MedicalDetails> MedicalDetails { get; set; }
        DbSet<Menu> Menu { get; set; }
        DbSet<OnlineConsultation> OnlineConsultation { get; set; }
        DbSet<OnlineConsultationMessage> OnlineConsultationMessage { get; set; }
        DbSet<Patient> Patient { get; set; }
        DbSet<Role> Role { get; set; }
        DbSet<User> User { get; set; }
        DbSet<UserRole> UserRole { get; set; }
        DbSet<Worker> Worker { get; set; }
        DbSet<WorkerKind> WorkerKind { get; set; }
    }
}
