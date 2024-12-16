using SMS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.UnitOfWorkService
{
    public interface IUnitOfWorkService
    {
        public IDepartmentService departmentService { get; set; }

        public IClassService classService { get; set; }

        public IExamType examType { get; set; }

        public ITeacherService teacherService { get; set; }
        public ISubjectService subjectService { get; set; }
        public ILevelService levelService { get; set; }

        public IStudentService studentService { get; set; }

        public IStudentExam studentExamService { get; set; } 
    }
}
