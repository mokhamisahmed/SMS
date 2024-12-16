using SMS.Data.Entities;
using SMS.Infrastructure.UnitOfWork;
using SMS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Services
{
    public class ExamTypeService : IExamType
    {
        private readonly IUnitOfWork<ExamType> unitOfWork;

        public ExamTypeService(IUnitOfWork<ExamType> unitOfWork)
        {

            this.unitOfWork = unitOfWork;

        }
        public async Task<int> Create(ExamType examType)
        {
           await this.unitOfWork.genericRepo.Create(examType);

          return await this.unitOfWork.Complete();
        }
    }
}
