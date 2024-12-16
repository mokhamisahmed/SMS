using AutoMapper;
using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.StudentRegistrationCore.Command.Entities;
using SMS.Data.Entities;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.StudentRegistrationExamCore.Command.Handlers
{
    public class StudentExamHandler : IRequestHandler<AddStudentExamCommand, RESPONSE<StudentRegistrationExam>>
    {
        private readonly IMapper mapper;

        private readonly IUnitOfWorkService unitOfWorkService;

        public StudentExamHandler(IMapper mapper, IUnitOfWorkService unitOfWorkService)
        {

            this.unitOfWorkService = unitOfWorkService;
            this.mapper = mapper;


        }


        public async Task<RESPONSE<StudentRegistrationExam>> Handle(AddStudentExamCommand request, CancellationToken cancellationToken)
        {
            var studentExam = mapper.Map<StudentRegistrationExam>(request);

            await unitOfWorkService.studentExamService.Create(studentExam);

            return await RequestHandler<StudentRegistrationExam>.Success(studentExam, "Student Exam created successfull");


        }
    }
}
