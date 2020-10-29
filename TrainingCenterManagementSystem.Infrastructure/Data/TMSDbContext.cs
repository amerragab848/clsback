using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TrainingCenterManagementSystem.Infrastructure.Data
{
    public partial class TMSDbContext : DbContext
    {
        public TMSDbContext()
        {
        }

        public TMSDbContext(DbContextOptions<TMSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Audiences> Audiences { get; set; }
        public virtual DbSet<CourseCategories> CourseCategories { get; set; }
        public virtual DbSet<CoursePrices> CoursePrices { get; set; }
        public virtual DbSet<CourseTypes> CourseTypes { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<DeleveryTypes> DeleveryTypes { get; set; }
        public virtual DbSet<Exams> Exams { get; set; }
        public virtual DbSet<Labs> Labs { get; set; }
        public virtual DbSet<LearningPaths> LearningPaths { get; set; }
        public virtual DbSet<LearningPathsCourses> LearningPathsCourses { get; set; }
        public virtual DbSet<MainMenu> MainMenu { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Offers> Offers { get; set; }
        public virtual DbSet<OffersCategory> OffersCategory { get; set; }
        public virtual DbSet<PriceTypes> PriceTypes { get; set; }
        public virtual DbSet<RoleMenu> RoleMenu { get; set; }
        public virtual DbSet<Vendors> Vendors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-AB8HUQU;Database=TMSDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Audiences>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CourseCategories>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CoursePrices>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CoursePrices)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__CoursePri__Cours__6D0D32F4");

                entity.HasOne(d => d.PriceType)
                    .WithMany(p => p.CoursePrices)
                    .HasForeignKey(d => d.PriceTypeId)
                    .HasConstraintName("FK__CoursePri__Price__6E01572D");
            });

            modelBuilder.Entity<CourseTypes>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Courses>(entity =>
            {
                entity.Property(e => e.AudienceProfileId).HasColumnName("AudienceProfileID");

                entity.Property(e => e.CourseTypeId).HasColumnName("courseTypeID");

                entity.Property(e => e.DeliveryTypeId).HasColumnName("DeliveryTypeID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PreRequisitesId).HasColumnName("PreRequisitesID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.CourseCategory)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CourseCategoryId)
                    .HasConstraintName("FK__Courses__CourseC__6EF57B66");

                entity.HasOne(d => d.CourseType)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.CourseTypeId)
                    .HasConstraintName("FK__Courses__courseT__6FE99F9F");

                entity.HasOne(d => d.DeliveryType)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.DeliveryTypeId)
                    .HasConstraintName("FK__Courses__Deliver__70DDC3D8");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.ExamId)
                    .HasConstraintName("FK__Courses__ExamId__71D1E811");

                entity.HasOne(d => d.Lab)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.LabId)
                    .HasConstraintName("FK__Courses__LabId__72C60C4A");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK__Courses__Materia__73BA3083");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK__Courses__VendorI__74AE54BC");
            });

            modelBuilder.Entity<DeleveryTypes>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Exams>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Labs>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<LearningPaths>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<LearningPathsCourses>(entity =>
            {
                entity.HasOne(d => d.Course)
                    .WithMany(p => p.LearningPathsCourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__LearningP__Cours__75A278F5");

                entity.HasOne(d => d.LearningPath)
                    .WithMany(p => p.LearningPathsCourses)
                    .HasForeignKey(d => d.LearningPathId)
                    .HasConstraintName("FK__LearningP__Learn__76969D2E");
            });

            modelBuilder.Entity<MainMenu>(entity =>
            {
                entity.Property(e => e.MainMenuId)
                    .HasColumnName("MainMenuID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MainMenuNameArab)
                    .IsRequired()
                    .HasColumnName("MainMenuName_Arab");

                entity.Property(e => e.MainMenuNameEnglish)
                    .IsRequired()
                    .HasColumnName("MainMenuName_English");
            });

            modelBuilder.Entity<Materials>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.MaiMenuId).HasColumnName("MaiMenuID");

                entity.Property(e => e.MenuNameArab)
                    .IsRequired()
                    .HasColumnName("MenuName_Arab");

                entity.Property(e => e.MenuNameEnglish)
                    .IsRequired()
                    .HasColumnName("MenuName_English");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.HasOne(d => d.MaiMenu)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.MaiMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menu_MainMenu");
            });

            modelBuilder.Entity<Offers>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.OfferCatgeory)
                    .WithMany(p => p.Offers)
                    .HasForeignKey(d => d.OfferCatgeoryId)
                    .HasConstraintName("FK__Offers__OfferCat__787EE5A0");
            });

            modelBuilder.Entity<OffersCategory>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PriceTypes>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<RoleMenu>(entity =>
            {
                entity.Property(e => e.RoleMenuId)
                    .HasColumnName("RoleMenuID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MenuId)
                    .IsRequired()
                    .HasColumnName("MenuID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.RoleMenuNavigation)
                    .WithOne(p => p.RoleMenu)
                    .HasForeignKey<RoleMenu>(d => d.RoleMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleMenu_Menu");
            });

            modelBuilder.Entity<Vendors>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
