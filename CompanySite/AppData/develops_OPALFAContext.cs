using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CompanySite.Models;

#nullable disable

namespace CompanySite.AppData
{
    public partial class develops_OPALFAContext : DbContext
    {
        public develops_OPALFAContext()
        {
        }

        public develops_OPALFAContext(DbContextOptions<develops_OPALFAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<CustomerMessage> CustomerMessages { get; set; }
        public virtual DbSet<CustomersProcce> CustomersProcces { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<GuestNotification> GuestNotifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data source=89.252.185.155\\MSSQLSERVER2019; Initial Catalog=develops_OPALFA; User ID= develops_emreaydin;Password=emre_6616;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("develops_emreaydin")
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.AdminPassword)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AdminUserName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerMessage>(entity =>
            {
                entity.Property(e => e.ContactLocation).HasComment("1- Anasayfa , 2- iletişim sayfası, 3-Diğer sayfalar");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerEmail).HasMaxLength(50);

                entity.Property(e => e.CustomerMessage1)
                    .HasColumnType("text")
                    .HasColumnName("CustomerMessage");

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.CustomerPhone).HasMaxLength(20);

                entity.Property(e => e.CustomerSubject).HasMaxLength(100);
            });

            modelBuilder.Entity<CustomersProcce>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressDetail).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser).HasMaxLength(50);

                entity.Property(e => e.CustomerEmail).HasMaxLength(50);

                entity.Property(e => e.CustomerJobType).HasMaxLength(100);

                entity.Property(e => e.CustomerOfficialName).HasMaxLength(100);

                entity.Property(e => e.CustomerPhone).HasMaxLength(15);

                entity.Property(e => e.CustomerTitle).HasMaxLength(100);

                entity.Property(e => e.CustomerWebSite).HasMaxLength(50);

                entity.Property(e => e.WhenDiscussed).HasColumnType("datetime");
            });

            modelBuilder.Entity<Guest>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GuestEmail).HasMaxLength(100);

                entity.Property(e => e.GuestName).HasMaxLength(100);

                entity.Property(e => e.GuestPhone).HasMaxLength(50);

                entity.Property(e => e.GuestSurname).HasMaxLength(100);
            });

            modelBuilder.Entity<GuestNotification>(entity =>
            {
                entity.ToTable("GuestNotification");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.GuestMail).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
