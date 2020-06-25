using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ZorgPortalIoT.Model
{
    public partial class b2d4ziekenhuisContext : DbContext
    {
        public b2d4ziekenhuisContext()
        {
        }

        public b2d4ziekenhuisContext(DbContextOptions<b2d4ziekenhuisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Sensor> Sensor { get; set; }
        public virtual DbSet<SensorMeting> SensorMeting { get; set; }
        public virtual DbSet<SensorType> SensorType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=b2d4-ziekenhuis;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("patient");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.Achternaam)
                    .IsRequired()
                    .HasColumnName("achternaam")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FotoUrl)
                    .HasColumnName("foto_url")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.GeslotenKamer)
                    .HasColumnName("gesloten_kamer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Leeftijd).HasColumnName("leeftijd");

                entity.Property(e => e.Voornaam)
                    .IsRequired()
                    .HasColumnName("voornaam")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sensor>(entity =>
            {
                entity.ToTable("sensor");

                entity.Property(e => e.SensorId).HasColumnName("sensor_id");

                entity.Property(e => e.Aan)
                    .HasColumnName("aan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Interval).HasColumnName("interval");

                entity.Property(e => e.Naam)
                    .HasColumnName("naam")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.SensorType).HasColumnName("sensor_type");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Sensor)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK_sensor_patient");

                entity.HasOne(d => d.SensorTypeNavigation)
                    .WithMany(p => p.Sensor)
                    .HasForeignKey(d => d.SensorType)
                    .HasConstraintName("FK_sensor_sensor_type");
            });

            modelBuilder.Entity<SensorMeting>(entity =>
            {
                entity.HasKey(e => e.MetingId);

                entity.ToTable("sensor_meting");

                entity.Property(e => e.MetingId).HasColumnName("meting_id");

                entity.Property(e => e.Alarm)
                    .HasColumnName("alarm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MetingTimestamp)
                    .HasColumnName("meting_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MetingWaarde).HasColumnName("meting_waarde");

                entity.Property(e => e.SensorId).HasColumnName("sensor_id");

                entity.HasOne(d => d.Sensor)
                    .WithMany(p => p.SensorMeting)
                    .HasForeignKey(d => d.SensorId)
                    .HasConstraintName("FK_sensor_meting_sensor");
            });

            modelBuilder.Entity<SensorType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("sensor_type");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasColumnName("naam")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
