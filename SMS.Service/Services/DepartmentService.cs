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
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork<Department> unitOfWork;

        public DepartmentService(IUnitOfWork<Department> unitOfWork)
        {

            this.unitOfWork= unitOfWork;

        }

        public async Task<int> Create(Department department)
        {
          await this.unitOfWork.genericRepo.Create(department);

            return await this.unitOfWork.Complete();

           
        }
    }
}
