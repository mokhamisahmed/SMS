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
    public class ParentService : IParentService
    {

        private readonly IUnitOfWork<Parent> unitOfWork;

        public ParentService(IUnitOfWork<Parent> unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<int> Create(Parent parent)
        {

         await this.unitOfWork.genericRepo.Create(parent);

         return await  this.unitOfWork.Complete();
        }
    }
}
