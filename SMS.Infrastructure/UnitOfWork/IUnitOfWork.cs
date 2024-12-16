using SMS.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork<T>:IDisposable
    {
        public IGenericRepo<T> genericRepo {  get; set; }

        public IStudentRegistrationExamRepo StudentRegistrationExamRepo { get; set; }
        public  Task<int> Complete();


        public IExamRepo ExamRepo { get; set; }


    }
}
