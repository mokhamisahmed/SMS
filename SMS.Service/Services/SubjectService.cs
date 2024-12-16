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
    public class SubjectService : ISubjectService
    {
        private readonly IUnitOfWork<Subject> unitOfWork;

        public SubjectService(IUnitOfWork<Subject> unitOfWork)
        {

            this.unitOfWork = unitOfWork;

        }


        public async Task<int> Create(Subject subject)
        {
          await this.unitOfWork.genericRepo.Create(subject);

         return  await this.unitOfWork.Complete();
        }
    }
}
