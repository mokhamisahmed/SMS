using AutoMapper;
using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.SubjectCore.Entities;
using SMS.Data.Entities;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.SubjectCore.Handlers
{
    public class SubjectCommandHandler : IRequestHandler<AddSubjectCommand, RESPONSE<Subject>>
    {
        private readonly IMapper mapper;

        private readonly IUnitOfWorkService unitOfWorkService;

        public SubjectCommandHandler(IMapper mapper, IUnitOfWorkService unitOfWorkService) {

            this.mapper = mapper;
             this.unitOfWorkService=unitOfWorkService;

        }
        public async Task<RESPONSE<Subject>> Handle(AddSubjectCommand request, CancellationToken cancellationToken)
        {
          var subject=  this.mapper.Map<Subject>(request);
          await  this.unitOfWorkService.subjectService.Create(subject);
            return await RequestHandler<Subject>.Success(subject,"subject created successful");
        }
    }
}
