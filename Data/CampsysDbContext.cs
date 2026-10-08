using App_CAMPSYS.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace App_CAMPSYS.Data;

public partial class CampsysDbContext : DbContext
{
    public CampsysDbContext()
    {
    }

    public CampsysDbContext(DbContextOptions<CampsysDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Departamento> Departamentos { get; set; }
    public virtual DbSet<Campista> Campistas { get; set; }
    public virtual DbSet<Tutor> Tutores { get; set; }
    public virtual DbSet<Staff> Staffs { get; set; }
    public virtual DbSet<Cabana> Cabanas { get; set; }
    public virtual DbSet<Actividades> Actividades { get; set; }
    public virtual DbSet<Inscripcion> Inscripciones { get; set; }
    public virtual DbSet<DetalleInscripcionActividad> DetallesInscripcionActividad { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string? connectionString = configuration.GetConnectionString("CampsysDbConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ---------- Departamento ----------
        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.DepartamentoId).HasName("PK__Departamento");
            entity.ToTable("Departamento");

            entity.Property(e => e.DepartamentoId).HasColumnName("id_departamento");
            entity.Property(e => e.Codigo).HasMaxLength(10).HasColumnName("codigo");
            entity.Property(e => e.Nombre).HasMaxLength(100).HasColumnName("nombre");
            entity.Property(e => e.Estado).HasDefaultValue(true).HasColumnName("estado");
        });

        // ---------- Campista ----------
        modelBuilder.Entity<Campista>(entity =>
        {
            entity.HasKey(e => e.CampistaId).HasName("PK__Campista");
            entity.ToTable("Campista");

            entity.HasIndex(e => e.DocId, "uq_campista_doc_id").IsUnique();

            entity.Property(e => e.CampistaId).HasColumnName("id_campista");
            entity.Property(e => e.NombreCompleto).HasMaxLength(150).HasColumnName("nombrecompleto");
            entity.Property(e => e.DocId).HasMaxLength(20).HasColumnName("doc_id");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.Sexo).HasMaxLength(10).HasColumnName("sexo");
            entity.Property(e => e.NumeroCelular).HasMaxLength(15).HasColumnName("numerocelular");
            entity.Property(e => e.Gmail).HasMaxLength(100).HasColumnName("gmail");
            entity.Property(e => e.Direccion).HasMaxLength(200).HasColumnName("direccion");
            entity.Property(e => e.DepartamentoId).HasColumnName("id_departamento");
            entity.Property(e => e.Tipo).HasMaxLength(10).HasDefaultValue("Campista").HasColumnName("tipo");

            entity.HasOne(d => d.Departamento).WithMany(p => p.Campistas)
                .HasForeignKey(d => d.DepartamentoId)
                .HasConstraintName("FK_Campista_Departamento");
        });

        // ---------- Tutor ----------
        modelBuilder.Entity<Tutor>(entity =>
        {
            entity.HasKey(e => e.TutorId).HasName("PK__Tutor");
            entity.ToTable("Tutor");

            entity.Property(e => e.TutorId).HasColumnName("id_tutor");
            entity.Property(e => e.NombreCompleto).HasMaxLength(150).HasColumnName("nombrecompleto");
            entity.Property(e => e.DocId).HasMaxLength(20).HasColumnName("doc_id");
            entity.Property(e => e.Edad).HasColumnName("edad");
            entity.Property(e => e.Sexo).HasMaxLength(10).HasColumnName("sexo");
            entity.Property(e => e.NumeroCelular).HasMaxLength(15).HasColumnName("numerocelular");
            entity.Property(e => e.CampistaId).HasColumnName("id_campista");

            entity.HasOne(d => d.Campista).WithMany(p => p.Tutores)
                .HasForeignKey(d => d.CampistaId)
                .HasConstraintName("FK_Tutor_Campista");
        });

        // ---------- Staff ----------
        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__Staff");
            entity.ToTable("Staff");

            entity.Property(e => e.StaffId).HasColumnName("id_staff");
            entity.Property(e => e.CampistaId).HasColumnName("id_campista");
            entity.Property(e => e.Rol).HasMaxLength(50).HasColumnName("rol");
            entity.Property(e => e.Password).HasMaxLength(100).HasDefaultValue("").HasColumnName("password");

            entity.HasOne(d => d.Campista).WithMany(p => p.Staffs)
                .HasForeignKey(d => d.CampistaId)
                .HasConstraintName("FK_Staff_Campista");
        });

        // ---------- Cabana ----------
        modelBuilder.Entity<Cabana>(entity =>
        {
            entity.HasKey(e => e.CabanaId).HasName("PK__Cabana");
            entity.ToTable("Cabana");

            entity.Property(e => e.CabanaId).HasColumnName("id_cabana");
            entity.Property(e => e.CodigoCabana).HasMaxLength(20).HasColumnName("codigocabana");
            entity.Property(e => e.Ubicacion).HasMaxLength(100).HasColumnName("ubicacion");
            entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            entity.Property(e => e.CuposDisponibles).HasColumnName("cuposdisponibles");
        });

        // ---------- Actividades ----------
        modelBuilder.Entity<Actividades>(entity =>
        {
            entity.HasKey(e => e.ActividadId).HasName("PK__Actividades");
            entity.ToTable("Actividades");

            entity.Property(e => e.ActividadId).HasColumnName("id_actividades");
            entity.Property(e => e.NombreActividad).HasMaxLength(100).HasColumnName("nombreactividad");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(10, 2)")
                .HasDefaultValue(100.00m)
                .HasColumnName("costo");
        });

        // ---------- Inscripcion ----------
        modelBuilder.Entity<Inscripcion>(entity =>
        {
            entity.HasKey(e => e.InscripcionId).HasName("PK__Inscripcion");
            // La tabla Inscripcion tiene un trigger habilitado en la BD. SQL Server no
            // permite combinar un trigger con la cláusula OUTPUT que EF Core usa por
            // defecto para leer el id_inscripcion autogenerado tras el INSERT
            // ("The target table 'Inscripcion' ... cannot have any enabled triggers
            // if the statement contains an OUTPUT clause"). Se desactiva esa cláusula
            // para esta tabla; EF Core usa automáticamente un método alterno
            // (SELECT SCOPE_IDENTITY()) para seguir obteniendo el id generado.
            entity.ToTable("Inscripcion", tb => tb.UseSqlOutputClause(false));

            entity.Property(e => e.InscripcionId).HasColumnName("id_inscripcion");
            entity.Property(e => e.FechaInscripcion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fechainscripcion");
            entity.Property(e => e.FechaInicio).HasColumnName("fechainicio");
            entity.Property(e => e.FechaFinalizacion).HasColumnName("fechafinalizacion");
            entity.Property(e => e.Costo).HasColumnType("decimal(10, 2)").HasColumnName("costo");
            entity.Property(e => e.Estado).HasMaxLength(10).HasDefaultValue("Activo").HasColumnName("estado");
            entity.Property(e => e.CampistaId).HasColumnName("id_campista");
            entity.Property(e => e.CabanaId).HasColumnName("id_cabana");

            entity.HasOne(d => d.Campista).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.CampistaId)
                .HasConstraintName("FK_Inscripcion_Campista");

            entity.HasOne(d => d.Cabana).WithMany(p => p.Inscripciones)
                .HasForeignKey(d => d.CabanaId)
                .HasConstraintName("FK_Inscripcion_Cabana");
        });

        // ---------- DetalleInscripcionActividad ----------
        modelBuilder.Entity<DetalleInscripcionActividad>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__Detalle_Inscripcion_Actividad");
            // Mismo caso que Inscripcion: esta tabla también tiene un trigger
            // habilitado, así que se desactiva la cláusula OUTPUT de EF Core.
            entity.ToTable("Detalle_Inscripcion_Actividad", tb => tb.UseSqlOutputClause(false));

            entity.Property(e => e.DetalleId).HasColumnName("id_detalle");
            entity.Property(e => e.InscripcionId).HasColumnName("id_inscripcion");
            entity.Property(e => e.ActividadId).HasColumnName("id_actividades");

            entity.HasOne(d => d.Inscripcion).WithMany(p => p.Detalles)
                .HasForeignKey(d => d.InscripcionId)
                .HasConstraintName("FK_Detalle_Inscripcion");

            entity.HasOne(d => d.Actividad).WithMany(p => p.Detalles)
                .HasForeignKey(d => d.ActividadId)
                .HasConstraintName("FK_Detalle_Actividad");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
