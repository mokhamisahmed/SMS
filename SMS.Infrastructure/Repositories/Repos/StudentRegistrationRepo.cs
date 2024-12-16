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
    public class StudentRegistrationRepo : GenericRepo<StudentRegistrationExam>, IStudentRegistrationExamRepo
    {
        private readonly ApplicationDbContext context;
        public StudentRegistrationRepo(ApplicationDbContext context) : base(context)
        {

            this.context = context;

        }

        public async Task<StudentRegistrationExam> GetTopStudentInExam(Expression<Func<StudentRegistrationExam, bool>> predicate)
        {
            return await context.StudentRegistrationExams.Where(predicate).OrderByDescending(s => s.grade).FirstOrDefaultAsync();

        }


    }
}
