using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.StudentRegistrationExamCore.Query.Entities;
using SMS.Data.Entities;
using SMS.Infrastructure.UnitOfWork;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.StudentRegistrationExamCore.Query.Handlers
{
    public class StudentExamHandlerQuery : IRequestHandler<GetStudentsExamQuery, RESPONSE<List<StudentRegistrationExam>>>
    {

        private readonly IUnitOfWorkService unitOfWorkService;

        public StudentExamHandlerQuery(IUnitOfWorkService unitOfWorkService)
        {
            this.unitOfWorkService= unitOfWorkService;
        }

        public async Task<RESPONSE<List<StudentRegistrationExam>>> Handle(GetStudentsExamQuery request, CancellationToken cancellationToken)
        {

         var students=  await  this.unitOfWorkService.studentExamService.GetStudentsExam(request.examId);

         return await RequestHandler<List<StudentRegistrationExam>>.Success(students,"Students in exams");
        }
    }
}
