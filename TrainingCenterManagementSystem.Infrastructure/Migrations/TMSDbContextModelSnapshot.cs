﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainingCenterManagementSystem.Infrastructure.Data;

namespace TrainingCenterManagementSystem.Infrastructure.Migrations
{
    [DbContext(typeof(TMSDbContext))]
    partial class TMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetRoles", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUsers", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Audiences", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Audiences");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.CourseCategories", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CourseCategories");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.CoursePrices", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<long?>("PriceTypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("PriceTypeId");

                    b.ToTable("CoursePrices");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.CourseTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("CourseTypes");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Courses", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AudienceProfileId")
                        .HasColumnName("AudienceProfileID")
                        .HasColumnType("bigint");

                    b.Property<long?>("CourseCategoryId")
                        .HasColumnType("bigint");

                    b.Property<long?>("CourseTypeId")
                        .HasColumnName("courseTypeID")
                        .HasColumnType("bigint");

                    b.Property<long?>("DeliveryTypeId")
                        .HasColumnName("DeliveryTypeID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ExamId")
                        .HasColumnType("bigint");

                    b.Property<long?>("LabId")
                        .HasColumnType("bigint");

                    b.Property<long?>("MaterialId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long?>("PreRequisitesId")
                        .HasColumnName("PreRequisitesID")
                        .HasColumnType("bigint");

                    b.Property<long?>("VendorId")
                        .HasColumnName("VendorID")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CourseCategoryId");

                    b.HasIndex("CourseTypeId");

                    b.HasIndex("DeliveryTypeId");

                    b.HasIndex("ExamId");

                    b.HasIndex("LabId");

                    b.HasIndex("MaterialId");

                    b.HasIndex("VendorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.DeleveryTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("DeleveryTypes");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Exams", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Labs", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Labs");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.LearningPaths", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("LearningPaths");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.LearningPathsCourses", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<long?>("LearningPathId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("LearningPathId");

                    b.ToTable("LearningPathsCourses");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.MainMenu", b =>
                {
                    b.Property<int>("MainMenuId")
                        .HasColumnName("MainMenuID")
                        .HasColumnType("int");

                    b.Property<string>("MainMenuNameArab")
                        .IsRequired()
                        .HasColumnName("MainMenuName_Arab")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainMenuNameEnglish")
                        .IsRequired()
                        .HasColumnName("MainMenuName_English")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MainMenuId");

                    b.ToTable("MainMenu");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Materials", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MenuID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LoadOnOpening")
                        .HasColumnType("int");

                    b.Property<int>("MaiMenuId")
                        .HasColumnName("MaiMenuID")
                        .HasColumnType("int");

                    b.Property<string>("MenuIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuNameArab")
                        .IsRequired()
                        .HasColumnName("MenuName_Arab")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuNameEnglish")
                        .IsRequired()
                        .HasColumnName("MenuName_English")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MenuOrder")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnName("URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuId");

                    b.HasIndex("MaiMenuId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Offers", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long?>("OfferCatgeoryId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OfferCatgeoryId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.OffersCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("OffersCategory");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.PriceTypes", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("PriceTypes");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.RoleMenu", b =>
                {
                    b.Property<int>("RoleMenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RoleMenuID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MenuId")
                        .IsRequired()
                        .HasColumnName("MenuID")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<int>("RoleId")
                        .HasColumnName("RoleID")
                        .HasColumnType("int");

                    b.HasKey("RoleMenuId");

                    b.ToTable("RoleMenu");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Vendors", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetRoleClaims", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUserClaims", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUserLogins", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUserRoles", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUserTokens", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.CoursePrices", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.Courses", "Course")
                        .WithMany("CoursePrices")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK__CoursePri__Cours__6D0D32F4");

                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.PriceTypes", "PriceType")
                        .WithMany("CoursePrices")
                        .HasForeignKey("PriceTypeId")
                        .HasConstraintName("FK__CoursePri__Price__6E01572D");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Courses", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.CourseCategories", "CourseCategory")
                        .WithMany("Courses")
                        .HasForeignKey("CourseCategoryId")
                        .HasConstraintName("FK__Courses__CourseC__6EF57B66");

                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.PriceTypes", "CourseType")
                        .WithMany("Courses")
                        .HasForeignKey("CourseTypeId")
                        .HasConstraintName("FK__Courses__courseT__6FE99F9F");

                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.DeleveryTypes", "DeliveryType")
                        .WithMany("Courses")
                        .HasForeignKey("DeliveryTypeId")
                        .HasConstraintName("FK__Courses__Deliver__70DDC3D8");

                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.Exams", "Exam")
                        .WithMany("Courses")
                        .HasForeignKey("ExamId")
                        .HasConstraintName("FK__Courses__ExamId__71D1E811");

                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.Labs", "Lab")
                        .WithMany("Courses")
                        .HasForeignKey("LabId")
                        .HasConstraintName("FK__Courses__LabId__72C60C4A");

                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.Materials", "Material")
                        .WithMany("Courses")
                        .HasForeignKey("MaterialId")
                        .HasConstraintName("FK__Courses__Materia__73BA3083");

                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.Vendors", "Vendor")
                        .WithMany("Courses")
                        .HasForeignKey("VendorId")
                        .HasConstraintName("FK__Courses__VendorI__74AE54BC");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.LearningPathsCourses", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.Courses", "Course")
                        .WithMany("LearningPathsCourses")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK__LearningP__Cours__75A278F5");

                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.LearningPaths", "LearningPath")
                        .WithMany("LearningPathsCourses")
                        .HasForeignKey("LearningPathId")
                        .HasConstraintName("FK__LearningP__Learn__76969D2E");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Menu", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.MainMenu", "MaiMenu")
                        .WithMany("Menu")
                        .HasForeignKey("MaiMenuId")
                        .HasConstraintName("FK_Menu_MainMenu")
                        .IsRequired();
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.Offers", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.OffersCategory", "OfferCatgeory")
                        .WithMany("Offers")
                        .HasForeignKey("OfferCatgeoryId")
                        .HasConstraintName("FK__Offers__OfferCat__787EE5A0");
                });

            modelBuilder.Entity("TrainingCenterManagementSystem.Infrastructure.Data.RoleMenu", b =>
                {
                    b.HasOne("TrainingCenterManagementSystem.Infrastructure.Data.Menu", "RoleMenuNavigation")
                        .WithOne("RoleMenu")
                        .HasForeignKey("TrainingCenterManagementSystem.Infrastructure.Data.RoleMenu", "RoleMenuId")
                        .HasConstraintName("FK_RoleMenu_Menu")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
