using SMS.Data.Entities;
using SMS.Infrastructure.UnitOfWork;
using SMS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Services
{
    public class StudentService:IStudentService
    {
        private readonly IUnitOfWork<Student> unitOfWork;
        public StudentService(IUnitOfWork<Student> unitOfWork) {

            this.unitOfWork = unitOfWork;


        }

        public async Task<int> Create(Student student)
        {
        var c= await this.unitOfWork.genericRepo.Create(student);

          return await this.unitOfWork.Complete();
        }
    }
}
