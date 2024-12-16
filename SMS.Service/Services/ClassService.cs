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
    public class ClassService : IClassService
    {
        private readonly IUnitOfWork<Class> unitOfWork;

        public ClassService(IUnitOfWork<Class> unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public async Task<int> Create(Class c)
        {
            this.unitOfWork.genericRepo.Create(c);

          return await this.unitOfWork.Complete();
        }
        public async Task<int> Update (Class c)
        {
         await this.unitOfWork.genericRepo.Update(c);

         return await  this.unitOfWork.Complete();

        }

        //public async Task<Class> Delete(int id)
        //{
        //   await this.unitOfWork.genericRepo.Delete(id);
        //}
    }
}
