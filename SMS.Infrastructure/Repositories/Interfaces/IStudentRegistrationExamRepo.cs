using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.Repositories.Interfaces
{
    public interface IStudentRegistrationExamRepo : IGenericRepo<StudentRegistrationExam>
    {
        public Task<StudentRegistrationExam> GetTopStudentInExam(Expression<Func<StudentRegistrationExam, bool>> predicate);

    }
}
