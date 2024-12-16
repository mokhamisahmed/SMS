using AutoMapper;
using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.ExamTypeCore.Entities;
using SMS.Data.Entities;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.ExamTypeCore.Handlers
{
    public class ExamTypeCommandHandlers : IRequestHandler<AddExamTypeCommand, RESPONSE<ExamType>>
    {
        private readonly IMapper mapper;

        private readonly IUnitOfWorkService unitOfWorkService;

        public ExamTypeCommandHandlers(IMapper mapper, IUnitOfWorkService unitOfWorkService)
        {
            this.mapper = mapper;
            this.unitOfWorkService=unitOfWorkService;
        }
        public async Task<RESPONSE<ExamType>> Handle(AddExamTypeCommand request, CancellationToken cancellationToken)
        {
          var examType=  this.mapper.Map<ExamType>(request);

           await this.unitOfWorkService.examType.Create(examType);


            return await RequestHandler<ExamType>.Success(examType,"ExamType is Created Successful");
       
        }
    }
}
