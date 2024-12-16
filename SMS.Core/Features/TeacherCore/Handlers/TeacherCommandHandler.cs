using AutoMapper;
using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.TeacherCore.Entities;
using SMS.Data.Entities;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.TeacherCore.Handlers
{
    public class TeacherCommandHandler : IRequestHandler<AddTeacherCommand, RESPONSE<Teacher>>
    {
        private readonly IMapper mapper;

        private readonly IUnitOfWorkService unitOfWorkService;

        public TeacherCommandHandler(IMapper mapper, IUnitOfWorkService unitOfWorkService) {
        
            this.mapper = mapper;

            this.unitOfWorkService=unitOfWorkService;
        }


        public async Task<RESPONSE<Teacher>> Handle(AddTeacherCommand request, CancellationToken cancellationToken)
        {
        var teacher=    this.mapper.Map<Teacher>(request);
          await  this.unitOfWorkService.teacherService.Create(teacher);
            return await RequestHandler<Teacher>.Success(teacher,"Teacher created successful");
        }
    }
}
