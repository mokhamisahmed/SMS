using SMS.Data.Entities;
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
    public class ExamService:IExamService
    {
        private readonly IUnitOfWork<Exam> unitOfWork;
        public ExamService(IUnitOfWork<Exam> unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }

        public async Task<List<Exam>> GetExamsBetweenInterval(DateTime start,DateTime end) {


          Expression<Func<Exam,bool>> func=e=>e.dateTime>=start &&e.dateTime<=end;

          return await this.unitOfWork.ExamRepo.GetEntities(func);

        }

      

    }
}
