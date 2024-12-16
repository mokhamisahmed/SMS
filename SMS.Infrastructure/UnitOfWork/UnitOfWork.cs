using SMS.Infrastructure.DbContext;
using SMS.Infrastructure.Repositories;
using SMS.Infrastructure.Repositories.Interfaces;
using SMS.Infrastructure.Repositories.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> :IUnitOfWork<T> where T : class
    {

        public IGenericRepo<T> genericRepo { get; set; }

        public IStudentRegistrationExamRepo StudentRegistrationExamRepo { get; set; }

        public IExamRepo ExamRepo { get; set; }

        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext context)
        {

            this.context = context;

            this.genericRepo = new GenericRepo<T>(context);
            this.StudentRegistrationExamRepo = new StudentRegistrationRepo(context); 

            this.ExamRepo=new ExamRepo(context);
    }
            
        public async Task<int> Complete()
        {

           return await this.context.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
