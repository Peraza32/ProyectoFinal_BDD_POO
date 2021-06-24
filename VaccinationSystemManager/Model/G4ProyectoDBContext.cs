using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace VaccinationSystemManager.Model
{
    public partial class G4ProyectoDBContext : DbContext
    {
        public G4ProyectoDBContext()
        {
        }

        public G4ProyectoDBContext(DbContextOptions<G4ProyectoDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Citizen> Citizens { get; set; }
        public virtual DbSet<Disability> Disabilities { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<DoseType> DoseTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<InCharge> InCharges { get; set; }
        public virtual DbSet<PresentedSideEffect> PresentedSideEffects { get; set; }
        public virtual DbSet<SessionControl> SessionControls { get; set; }
        public virtual DbSet<SideEffect> SideEffects { get; set; }
        public virtual DbSet<VaccinationCenter> VaccinationCenters { get; set; }
        public virtual DbSet<VaccinationProcess> VaccinationProcesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-A69GIG7;Initial Catalog=G4ProyectoDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("APPOINTMENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppointmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("appointment_date");

                entity.Property(e => e.DuiCitizen)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dui_citizen");

                entity.Property(e => e.IdCenter).HasColumnName("id_center");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.ShotType).HasColumnName("shot_type");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__dui_c__5070F446");

                entity.HasOne(d => d.IdCenterNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdCenter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_ce__4F7CD00D");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__id_em__5165187F");

                entity.HasOne(d => d.ShotTypeNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.ShotType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__shot___4E88ABD4");
            });

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("CABIN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CabinAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cabin_address");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("e_mail");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phone_number")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Citizen>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CITIZEN__D876F1BE29DA0C18");

                entity.ToTable("CITIZEN");

                entity.Property(e => e.Dui)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.CitizenAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("citizen_address");

                entity.Property(e => e.CitizenName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("citizen_name");

                entity.Property(e => e.EMail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("e_mail");

                entity.Property(e => e.IdentifierNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("identifier_number");

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("phone_number")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Disability>(entity =>
            {
                entity.ToTable("DISABILITY");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DisabilityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("disability_name");

                entity.Property(e => e.DuiCitizen)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dui_citizen");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Disabilities)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DISABILIT__dui_c__44FF419A");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.ToTable("DISEASE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DiseaseName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("disease_name");

                entity.Property(e => e.DuiCitizen)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dui_citizen");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.Diseases)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DISEASE__dui_cit__4222D4EF");
            });

            modelBuilder.Entity<DoseType>(entity =>
            {
                entity.ToTable("DOSE_TYPE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ShotType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shot_type");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("e_mail");

                entity.Property(e => e.EmployeeAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("employee_address");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");

                entity.Property(e => e.EmployeePassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_password");

                entity.Property(e => e.EmployeeUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_user");

                entity.Property(e => e.IdType).HasColumnName("id_type");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLOYEE__id_typ__4BAC3F29");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("EMPLOYEE_TYPE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EmployeeType1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_type");
            });

            modelBuilder.Entity<InCharge>(entity =>
            {
                entity.HasKey(e => new { e.IdEmployee, e.IdCabin })
                    .HasName("PK_in_charge");

                entity.ToTable("IN_CHARGE");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.InCharges)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__IN_CHARGE__id_ca__5CD6CB2B");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.InCharges)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__IN_CHARGE__id_em__5BE2A6F2");
            });

            modelBuilder.Entity<PresentedSideEffect>(entity =>
            {
                entity.ToTable("PRESENTED_SIDE_EFFECT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppearanceTime).HasColumnName("appearance_time");

                entity.Property(e => e.IdSideEffect).HasColumnName("id_side_effect");

                entity.Property(e => e.IdVaccinationProcess).HasColumnName("id_vaccination_process");

                entity.HasOne(d => d.IdSideEffectNavigation)
                    .WithMany(p => p.PresentedSideEffects)
                    .HasForeignKey(d => d.IdSideEffect)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRESENTED__id_si__59063A47");

                entity.HasOne(d => d.IdVaccinationProcessNavigation)
                    .WithMany(p => p.PresentedSideEffects)
                    .HasForeignKey(d => d.IdVaccinationProcess)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRESENTED__id_va__5812160E");
            });

            modelBuilder.Entity<SessionControl>(entity =>
            {
                entity.ToTable("SESSION_CONTROL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.SessionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("session_date");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.SessionControls)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SESSION_C__id_ca__5535A963");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.SessionControls)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SESSION_C__id_em__5441852A");
            });

            modelBuilder.Entity<SideEffect>(entity =>
            {
                entity.ToTable("SIDE_EFFECT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Effect)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("effect");
            });

            modelBuilder.Entity<VaccinationCenter>(entity =>
            {
                entity.ToTable("VACCINATION_CENTER");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.CenterAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("center_address");

                entity.Property(e => e.CenterName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("center_name");
            });

            modelBuilder.Entity<VaccinationProcess>(entity =>
            {
                entity.ToTable("VACCINATION_PROCESS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DuiCitizen)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dui_citizen");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.ShotType).HasColumnName("shot_type");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.VaccinationDate)
                    .HasColumnType("date")
                    .HasColumnName("vaccination_date");

                entity.Property(e => e.VaccinationTime).HasColumnName("vaccination_time");

                entity.HasOne(d => d.DuiCitizenNavigation)
                    .WithMany(p => p.VaccinationProcesses)
                    .HasForeignKey(d => d.DuiCitizen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__dui_c__48CFD27E");

                entity.HasOne(d => d.ShotTypeNavigation)
                    .WithMany(p => p.VaccinationProcesses)
                    .HasForeignKey(d => d.ShotType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VACCINATI__shot___47DBAE45");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
