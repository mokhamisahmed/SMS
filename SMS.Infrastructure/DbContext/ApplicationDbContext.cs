using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMS.Data.Entities;

namespace SMS.Infrastructure.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {



        }


        public DbSet<Department> Departments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Exam> Exams { get; set; }

        public DbSet<ExamType> ExamTypes { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Level> Levels { get; set; }

        public DbSet<LevelSubject> LevelSubjects { get; set; }

        
        public DbSet<StudentRegistrationExam> StudentRegistrationExams { get; set; }

        public DbSet<Class> Classes { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentRegistrationExam>(s =>
            {

                // تحديد المفتاح المركب
                s.HasKey(e => new { e.studentId, e.ExamId });

                // تعيين العلاقات (إذا لزم الأمر)
                s.HasOne(e => e.student)
                      .WithMany()
                      .HasForeignKey(e => e.studentId)
                      .OnDelete(DeleteBehavior.Restrict);

                s.HasOne(e => e.exam)
                      .WithMany()
                      .HasForeignKey(e => e.ExamId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        
            

            modelBuilder.Entity<Department>(department =>
            {

                department.HasKey(d => d.Id);
                department.Property(d => d.Name).IsRequired(false);
                department.HasIndex(d => d.Name).IsUnique();


                department.HasOne(d => d.superVisor)
                .WithOne()
                .HasForeignKey<Department>(d => d.superVisorId)
                .OnDelete(DeleteBehavior.Restrict);

            });
            modelBuilder.Entity<Teacher>(
                teacher =>
                {
                    teacher.HasKey(t => t.Id);
                    teacher.HasOne(t => t.department)
                    .WithMany(d => d.teachers)
                    .HasForeignKey(t => t.departmentId)
                    .OnDelete(DeleteBehavior.Restrict);

                    teacher.HasOne(t => t.teacher)
                    .WithOne()
                    .HasForeignKey<Teacher>(t => t.teacherId)
                    .OnDelete(DeleteBehavior.Restrict);
                }

                );

            modelBuilder.Entity<Student>(
                student =>
                {
                    student.HasKey(s => s.Id);

                    student.HasOne(s => s.student)
                    .WithOne()
                    .HasForeignKey<Student>(s => s.studentId)
                    .OnDelete(DeleteBehavior.Restrict);

                    student.HasOne(s => s.Class)
                    .WithMany(c => c.students)
                    .HasForeignKey(s => s.ClassId)
                    .OnDelete(DeleteBehavior.Restrict);
                }
                );

            modelBuilder.Entity<Exam>(
                exam =>
                {
                    exam.HasKey(s => s.Id);

                    exam.HasOne(e => e.subject)
                    .WithMany(s => s.exams)
                    .HasForeignKey(e => e.subjectId);
                    exam.HasOne(e => e.examType)
                    .WithMany(t => t.exams)
                    .HasForeignKey(e => e.examTypeId)
                    .OnDelete(DeleteBehavior.Restrict);
                }

                );

            modelBuilder.Entity<ExamType>(
                type =>
                {
                    type.HasKey(t => t.Id);
                }
            );

            modelBuilder.Entity<Level>(
                level =>
                {
                    level.HasKey(l => l.Id);

                }
                );

            modelBuilder.Entity<LevelSubject>(
                levelSubject =>
                {
                    levelSubject.HasKey(l => new { l.levelId, l.subjectId });

                    // إعداد العلاقات والمفاتيح الأجنبية
                    levelSubject.HasOne(ls => ls.level)
                        .WithMany() // أو يمكنك تحديد العلاقة مع Level إذا كان لديك مجموعة من LevelSubjects في Level
                        .HasForeignKey(ls => ls.levelId)
                        .OnDelete(DeleteBehavior.Restrict); // يمكنك تحديد سلوك الحذف المناسب هنا

                    levelSubject.HasOne(ls => ls.subject)
                        .WithMany() // أو يمكنك تحديد العلاقة مع Subject إذا كان لديك مجموعة من LevelSubjects في Subject
                        .HasForeignKey(ls => ls.subjectId)
                        .OnDelete(DeleteBehavior.Restrict);



                }
                );


        }
    }




    }
