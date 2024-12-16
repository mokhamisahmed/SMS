using Microsoft.EntityFrameworkCore;
using SMS.Data.Entities;
using SMS.Infrastructure.DbContext;
using SMS.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.Repositories.Repos
{
    public class ExamRepo:GenericRepo<Exam>,IExamRepo
    {

        private readonly ApplicationDbContext context;
        public ExamRepo(ApplicationDbContext context):base(context) { 
        
         this.context=context;

        }


        public async Task<List<dynamic>> GetStudentCountPerExam()
        {

            var examStudentCounts = await this.context.Exams.Select(
                exam=>new {
                    ExamId = exam.Id,
                    SubjectName = exam.subject.SubjectName,
                    StudentCount=exam.students.Count
                }
                ).ToListAsync();

            return examStudentCounts.Cast<dynamic>().ToList();

        }


        public async Task<List<dynamic>> GetExamOrdering()
        {
            var orderedExams = await this.context.Exams.Select(
                exam=>new
                {
                    ExamId = exam.Id,
                    SubjectName = exam.subject.SubjectName,
                    StudentCount = exam.students.Count

                }
                

                ).OrderByDescending(e=>e.StudentCount).ToListAsync();

            return orderedExams.Cast<dynamic>().ToList();

        }


    }
}
