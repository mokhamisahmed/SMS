using AutoMapper;
using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.StudentCore.Command.Entities;
using SMS.Data.Entities;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.StudentCore.Command.Handlers
{
    public class StudentCommandHandler : IRequestHandler<AddStudentCommand, RESPONSE<Student>>
    {

        private readonly IMapper mapper;

        private readonly IUnitOfWorkService unitOfWorkService;

        public StudentCommandHandler(IMapper mapper, IUnitOfWorkService unitOfWorkService)
        {
            this.mapper = mapper;   

            this.unitOfWorkService=unitOfWorkService;
        }



        public async Task<RESPONSE<Student>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
          Student s=  this.mapper.Map<Student>(request);

           await this.unitOfWorkService.studentService.Create(s);

            return await RequestHandler<Student>.Success(s,"student Created successful");
                
                }
    }
}
