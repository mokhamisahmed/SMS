using AutoMapper;
using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.ParentCore.Entities;
using SMS.Data.Entities;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.ParentCore.Handlers
{
    public class ParentCommandHandler : IRequestHandler<AddParentCommand, RESPONSE<Parent>>
    {
        private readonly IMapper mapper;

        private readonly IUnitOfWorkService unitOfWorkService;

        public ParentCommandHandler(IMapper mapper, IUnitOfWorkService unitOfWorkService) { 
        
            this.mapper= mapper;
            this.unitOfWorkService= unitOfWorkService;
        
        }

        public Task<RESPONSE<Parent>> Handle(AddParentCommand request, CancellationToken cancellationToken)
        {

          var parent=  this.mapper.Map<Parent>(request);

            return null;
            //this.unitOfWorkService.
        }
    }
}
