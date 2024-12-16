using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Interfaces
{
    public interface IStudentExam
    {
        public Task<int> Create(StudentRegistrationExam studentRegistrationExam);


        public Task<List<StudentRegistrationExam>> GetStudentsExam(int id);


     


    }
}
