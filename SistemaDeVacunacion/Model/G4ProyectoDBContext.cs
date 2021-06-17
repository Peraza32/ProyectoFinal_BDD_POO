using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SistemaDeVacunacion.Model
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

        public virtual DbSet<Cabina> Cabinas { get; set; }
        public virtual DbSet<CentroVacunacion> CentroVacunacions { get; set; }
        public virtual DbSet<Citum> Cita { get; set; }
        public virtual DbSet<Ciudadano> Ciudadanos { get; set; }
        public virtual DbSet<Discapacidad> Discapacidads { get; set; }
        public virtual DbSet<EfectoPresentado> EfectoPresentados { get; set; }
        public virtual DbSet<EfectoSecundario> EfectoSecundarios { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Encargado> Encargados { get; set; }
        public virtual DbSet<Enfermedad> Enfermedads { get; set; }
        public virtual DbSet<ProcesoDeVacunacion> ProcesoDeVacunacions { get; set; }
        public virtual DbSet<Sesion> Sesions { get; set; }
        public virtual DbSet<TipoDosi> TipoDoses { get; set; }
        public virtual DbSet<TipoEmpleado> TipoEmpleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=G4ProyectoDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cabina>(entity =>
            {
                entity.ToTable("CABINA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CentroVacunacion>(entity =>
            {
                entity.ToTable("CENTRO_VACUNACION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Capacidad).HasColumnName("capacidad");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Citum>(entity =>
            {
                entity.ToTable("CITA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DuiCiudadano)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dui_ciudadano");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdCentro).HasColumnName("id_centro");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.TipoDosis).HasColumnName("tipo_dosis");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA__dui_ciudad__5070F446");

                entity.HasOne(d => d.IdCentroNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdCentro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA__id_centro__4F7CD00D");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA__id_emplead__5165187F");

                entity.HasOne(d => d.TipoDosisNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.TipoDosis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CITA__tipo_dosis__4E88ABD4");
            });

            modelBuilder.Entity<Ciudadano>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CIUDADAN__D876F1BED25899CF");

                entity.ToTable("CIUDADANO");

                entity.Property(e => e.Dui)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dui");

                entity.Property(e => e.Correo)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NumeroIdentificador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("numero_identificador");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Discapacidad>(entity =>
            {
                entity.ToTable("DISCAPACIDAD");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Discapacidad1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("discapacidad");

                entity.Property(e => e.DuiCiudadano)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dui_ciudadano");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.Discapacidads)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DISCAPACI__dui_c__44FF419A");
            });

            modelBuilder.Entity<EfectoPresentado>(entity =>
            {
                entity.HasKey(e => new { e.IdProcesoVacunacion, e.IdEfectoSecundario })
                    .HasName("PK_efecto_presentado");

                entity.ToTable("EFECTO_PRESENTADO");

                entity.Property(e => e.IdProcesoVacunacion).HasColumnName("id_proceso_vacunacion");

                entity.Property(e => e.IdEfectoSecundario).HasColumnName("id_efecto_secundario");

                entity.HasOne(d => d.IdEfectoSecundarioNavigation)
                    .WithMany(p => p.EfectoPresentados)
                    .HasForeignKey(d => d.IdEfectoSecundario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EFECTO_PR__id_ef__59063A47");

                entity.HasOne(d => d.IdProcesoVacunacionNavigation)
                    .WithMany(p => p.EfectoPresentados)
                    .HasForeignKey(d => d.IdProcesoVacunacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EFECTO_PR__id_pr__5812160E");
            });

            modelBuilder.Entity<EfectoSecundario>(entity =>
            {
                entity.ToTable("EFECTO_SECUNDARIO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Efecto)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("efecto");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("EMPLEADO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contrasena)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contrasena");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdTipo).HasColumnName("id_tipo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMPLEADO__id_tip__4BAC3F29");
            });

            modelBuilder.Entity<Encargado>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpleado, e.IdCabina })
                    .HasName("PK_encargado");

                entity.ToTable("ENCARGADO");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.Encargados)
                    .HasForeignKey(d => d.IdCabina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENCARGADO__id_ca__5CD6CB2B");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Encargados)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENCARGADO__id_em__5BE2A6F2");
            });

            modelBuilder.Entity<Enfermedad>(entity =>
            {
                entity.ToTable("ENFERMEDAD");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DuiCiudadano)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dui_ciudadano");

                entity.Property(e => e.Enfermedad1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enfermedad");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.Enfermedads)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ENFERMEDA__dui_c__4222D4EF");
            });

            modelBuilder.Entity<ProcesoDeVacunacion>(entity =>
            {
                entity.ToTable("PROCESO_DE_VACUNACION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DuiCiudadano)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("dui_ciudadano");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.HoraFinal).HasColumnName("hora_final");

                entity.Property(e => e.HoraInicio).HasColumnName("hora_inicio");

                entity.Property(e => e.HoraVacunacion).HasColumnName("hora_vacunacion");

                entity.Property(e => e.TipoDosis).HasColumnName("tipo_dosis");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.ProcesoDeVacunacions)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROCESO_D__dui_c__48CFD27E");

                entity.HasOne(d => d.TipoDosisNavigation)
                    .WithMany(p => p.ProcesoDeVacunacions)
                    .HasForeignKey(d => d.TipoDosis)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROCESO_D__tipo___47DBAE45");
            });

            modelBuilder.Entity<Sesion>(entity =>
            {
                entity.ToTable("SESION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.Sesions)
                    .HasForeignKey(d => d.IdCabina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SESION__id_cabin__5535A963");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Sesions)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SESION__id_emple__5441852A");
            });

            modelBuilder.Entity<TipoDosi>(entity =>
            {
                entity.ToTable("TIPO_DOSIS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<TipoEmpleado>(entity =>
            {
                entity.ToTable("TIPO_EMPLEADO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
