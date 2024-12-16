using SMS.Data.Entities;
using SMS.Infrastructure.DbContext;
using SMS.Infrastructure.UnitOfWork;
using SMS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Services
{
    public class StudentExamService : IStudentExam
    {
        private readonly IUnitOfWork<StudentRegistrationExam> unitOfWork;
        private readonly ApplicationDbContext context;
        public StudentExamService(IUnitOfWork<StudentRegistrationExam> unitOfWork) { 

        this.unitOfWork= unitOfWork;

        }
        public async Task<int> Create(StudentRegistrationExam studentRegistrationExam)
        {
          await this.unitOfWork.StudentRegistrationExamRepo.Create(studentRegistrationExam);

         return  await this.unitOfWork.Complete();

        }

        public async Task<List<StudentRegistrationExam>> GetStudentsExam(int id)
        {
        
         Expression<Func<StudentRegistrationExam, bool>> exp = x => x.ExamId == id;

         return  await this.unitOfWork.StudentRegistrationExamRepo.GetEntitiesById(exp);

           
        }


        public async Task<StudentRegistrationExam> GetTopStudentInExam(int Examid) {

            Expression<Func<StudentRegistrationExam, bool>> exp = x => x.ExamId == Examid;

            return await this.unitOfWork.StudentRegistrationExamRepo.GetTopStudentInExam(exp);
        }





    }
}
