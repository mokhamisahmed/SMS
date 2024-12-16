using AutoMapper;
using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.ExamCore.Command.Entities;
using SMS.Data.Entities;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.ExamCore.Command.Handlers
{
    public class ExamCommandHandler : IRequestHandler<AddExamCommand, RESPONSE<Exam>>
    {
        private readonly IMapper mapper;

        private readonly IUnitOfWorkService unitOfWorkService;  

        public ExamCommandHandler(IMapper mapper, IUnitOfWorkService unitOfWorkService) { 
        this.mapper = mapper;
        this.unitOfWorkService=unitOfWorkService;
        }


        public Task<RESPONSE<Exam>> Handle(AddExamCommand request, CancellationToken cancellationToken)
        {
            //this.unitOfWorkService.

            return null;
        }


    }
}
