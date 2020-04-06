using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PetNestInitial.Models
{
    public partial class PetNestTestContext : DbContext
    {
        public PetNestTestContext()
        {
        }

        public PetNestTestContext(DbContextOptions<PetNestTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnimalLocator> AnimalLocator { get; set; }
        public virtual DbSet<Animals> Animals { get; set; }
        public virtual DbSet<Favorites> Favorites { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<MessageSystem> MessageSystem { get; set; }
        public virtual DbSet<ReportUsers> ReportUsers { get; set; }
        public virtual DbSet<Shelters> Shelters { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-U60Q17BB;Database=PetNestTest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalLocator>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnimalId).HasColumnName("AnimalID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.HasOne(d => d.Animal)
                    .WithMany()
                    .HasForeignKey(d => d.AnimalId)
                    .HasConstraintName("FK__AnimalLoc__Anima__30F848ED");

                entity.HasOne(d => d.Location)
                    .WithMany()
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__AnimalLoc__Locat__31EC6D26");
            });

            modelBuilder.Entity<Animals>(entity =>
            {
                entity.HasKey(e => e.AnimalId)
                    .HasName("PK__Animals__A21A7327D21F1C7D");

                entity.Property(e => e.AnimalId)
                    .HasColumnName("AnimalID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnimalAboutMe)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AnimalBreed)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AnimalName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AnimalSex)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AnimalType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsSpayedOrNeutered)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.VaccinationUpToDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK__Animals__OwnerID__267ABA7A");
            });

            modelBuilder.Entity<Favorites>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnimalId).HasColumnName("AnimalID");

                entity.Property(e => e.FavoriteId).HasColumnName("FavoriteID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Favorites__UserI__2A4B4B5E");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__Location__E7FEA4773FC2EF3B");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.St)
                    .HasColumnName("ST")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MessageSystem>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__MessageS__C87C037C38A4EBCA");

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MessageBody)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Recipient)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReportUserUserId)
                    .HasColumnName("ReportUser_UserID")
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportUsers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ReasonId)
                    .HasColumnName("ReasonID")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ReportResolved)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shelters>(entity =>
            {
                entity.HasKey(e => e.ShelterId)
                    .HasName("PK__Shelters__E2CDF574F1CD9B17");

                entity.Property(e => e.ShelterId)
                    .HasColumnName("ShelterID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ShelterDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShelterName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserProf__1788CC4C70DC6F1E");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.AboutMe)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PictureUrl)
                    .HasColumnName("PictureURL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserGender)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
