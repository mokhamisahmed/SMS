﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMS.Infrastructure.DbContext;

#nullable disable

namespace SMS.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241213162209_t")]
    partial class t
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LevelSubject", b =>
                {
                    b.Property<int>("levelsId")
                        .HasColumnType("int");

                    b.Property<int>("subjectsId")
                        .HasColumnType("int");

                    b.HasKey("levelsId", "subjectsId");

                    b.HasIndex("subjectsId");

                    b.ToTable("LevelSubject");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SMS.Data.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("SMS.Data.Entities.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("levelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("levelId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("SMS.Data.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("superVisorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.HasIndex("superVisorId")
                        .IsUnique();

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SMS.Data.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DurationExam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FinalGrade")
                        .HasColumnType("float");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("examTypeId")
                        .HasColumnType("int");

                    b.Property<int>("subjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("examTypeId");

                    b.HasIndex("subjectId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("SMS.Data.Entities.ExamType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ExamTypes");
                });

            modelBuilder.Entity("SMS.Data.Entities.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LevelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("SMS.Data.Entities.LevelSubject", b =>
                {
                    b.Property<int>("levelId")
                        .HasColumnType("int");

                    b.Property<int>("subjectId")
                        .HasColumnType("int");

                    b.HasKey("levelId", "subjectId");

                    b.HasIndex("subjectId");

                    b.ToTable("LevelSubjects");
                });

            modelBuilder.Entity("SMS.Data.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("studentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("studentId")
                        .IsUnique();

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SMS.Data.Entities.StudentRegistrationExam", b =>
                {
                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int?>("ExamId1")
                        .HasColumnType("int");

                    b.Property<double?>("grade")
                        .HasColumnType("float");

                    b.HasKey("studentId", "ExamId");

                    b.HasIndex("ExamId");

                    b.HasIndex("ExamId1");

                    b.ToTable("StudentRegistrationExams");
                });

            modelBuilder.Entity("SMS.Data.Entities.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SMS.Data.Entities.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("departmentId")
                        .HasColumnType("int");

                    b.Property<string>("teacherId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.HasIndex("teacherId")
                        .IsUnique();

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("LevelSubject", b =>
                {
                    b.HasOne("SMS.Data.Entities.Level", null)
                        .WithMany()
                        .HasForeignKey("levelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Data.Entities.Subject", null)
                        .WithMany()
                        .HasForeignKey("subjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SMS.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SMS.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SMS.Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SMS.Data.Entities.Class", b =>
                {
                    b.HasOne("SMS.Data.Entities.Level", "level")
                        .WithMany()
                        .HasForeignKey("levelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("level");
                });

            modelBuilder.Entity("SMS.Data.Entities.Department", b =>
                {
                    b.HasOne("SMS.Data.Entities.ApplicationUser", "superVisor")
                        .WithOne()
                        .HasForeignKey("SMS.Data.Entities.Department", "superVisorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("superVisor");
                });

            modelBuilder.Entity("SMS.Data.Entities.Exam", b =>
                {
                    b.HasOne("SMS.Data.Entities.ExamType", "examType")
                        .WithMany("exams")
                        .HasForeignKey("examTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SMS.Data.Entities.Subject", "subject")
                        .WithMany("exams")
                        .HasForeignKey("subjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("examType");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("SMS.Data.Entities.LevelSubject", b =>
                {
                    b.HasOne("SMS.Data.Entities.Level", "level")
                        .WithMany()
                        .HasForeignKey("levelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SMS.Data.Entities.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("level");

                    b.Navigation("subject");
                });

            modelBuilder.Entity("SMS.Data.Entities.Student", b =>
                {
                    b.HasOne("SMS.Data.Entities.Class", "Class")
                        .WithMany("students")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SMS.Data.Entities.ApplicationUser", "student")
                        .WithOne()
                        .HasForeignKey("SMS.Data.Entities.Student", "studentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("student");
                });

            modelBuilder.Entity("SMS.Data.Entities.StudentRegistrationExam", b =>
                {
                    b.HasOne("SMS.Data.Entities.Exam", "exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMS.Data.Entities.Exam", null)
                        .WithMany("students")
                        .HasForeignKey("ExamId1");

                    b.HasOne("SMS.Data.Entities.Student", "student")
                        .WithMany()
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("exam");

                    b.Navigation("student");
                });

            modelBuilder.Entity("SMS.Data.Entities.Teacher", b =>
                {
                    b.HasOne("SMS.Data.Entities.Department", "department")
                        .WithMany("teachers")
                        .HasForeignKey("departmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SMS.Data.Entities.ApplicationUser", "teacher")
                        .WithOne()
                        .HasForeignKey("SMS.Data.Entities.Teacher", "teacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("department");

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("SMS.Data.Entities.Class", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("SMS.Data.Entities.Department", b =>
                {
                    b.Navigation("teachers");
                });

            modelBuilder.Entity("SMS.Data.Entities.Exam", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("SMS.Data.Entities.ExamType", b =>
                {
                    b.Navigation("exams");
                });

            modelBuilder.Entity("SMS.Data.Entities.Subject", b =>
                {
                    b.Navigation("exams");
                });
#pragma warning restore 612, 618
        }
    }
}
