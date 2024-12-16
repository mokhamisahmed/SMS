using AutoMapper;
using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.LevelCore.Entities;
using SMS.Data.Entities;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.LevelCore.Handlers
{
    public class LevelCommandHandler : IRequestHandler<AddLevelCommand, RESPONSE<Level>>
    {
        private readonly IMapper mapper;

        private readonly IUnitOfWorkService unitOfWorkService;
        public LevelCommandHandler(IMapper mapper, IUnitOfWorkService unitOfWorkService) { 
        
        this.mapper = mapper;
            this.unitOfWorkService = unitOfWorkService;
        }
        public async Task<RESPONSE<Level>> Handle(AddLevelCommand request, CancellationToken cancellationToken)
        {
           var level=  this.mapper.Map<Level>(request);

            await this.unitOfWorkService.levelService.Create(level);

            return await RequestHandler<Level>.Success(level,"level is added successul");
        }
    }
}
