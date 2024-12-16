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
    public class TeacherService : ITeacherService
    {
        private readonly IUnitOfWork<Teacher> unitOfWork;

        public TeacherService(IUnitOfWork<Teacher> unitOfWork)
        {

            this.unitOfWork=unitOfWork;

        }
        public async Task<int> Create(Teacher teacher)
        {

          await this.unitOfWork.genericRepo.Create(teacher);

           return await this.unitOfWork.Complete();
        }
    }
}
