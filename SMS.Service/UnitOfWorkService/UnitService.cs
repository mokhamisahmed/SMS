using SMS.Data.Entities;
using SMS.Infrastructure.DbContext;
using SMS.Infrastructure.UnitOfWork;
using SMS.Service.Interfaces;
using SMS.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.UnitOfWorkService
{
    public class UnitService:IUnitOfWorkService
    {
        public IDepartmentService departmentService { get; set; }
        public IStudentService studentService { get; set; }

        public IClassService classService { get;set; }
        public IExamType examType { get; set; }
        public ILevelService levelService { get; set; }

        public ITeacherService teacherService { get; set; }

        public IStudentExam studentExamService { get; set; }    

        public ISubjectService subjectService { get; set; }

        private readonly ApplicationDbContext context;
        public UnitService(ApplicationDbContext context) {
      
          this.departmentService=new DepartmentService(new UnitOfWork<Department>(context));
            this.examType = new ExamTypeService(new UnitOfWork<ExamType>(context));
            this.levelService = new LevelService(new UnitOfWork<Level>(context));
            this.classService = new ClassService(new UnitOfWork<Class>(context));
            this.subjectService = new SubjectService(new UnitOfWork<Subject>(context));
            this.teacherService = new TeacherService(new UnitOfWork<Teacher>(context));
            this.studentService = new StudentService(new UnitOfWork<Student>(context));

            this.studentExamService = new StudentExamService(new UnitOfWork<StudentRegistrationExam>(context));

        }



    }
}
