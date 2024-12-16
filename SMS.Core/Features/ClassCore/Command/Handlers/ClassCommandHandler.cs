using AutoMapper;
using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.ClassCore.Command.Entities;
using SMS.Data.Entities;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.ClassCore.Command.Handlers
{
    public class ClassCommandHandler : IRequestHandler<AddClassCommand, RESPONSE<Class>>,
        IRequestHandler<UpdateClassCommand, RESPONSE<Class>>,
        IRequestHandler<DeleteClassCommand,RESPONSE<Class>>
    {
        private readonly IMapper mapper;

        private readonly IUnitOfWorkService unitOfWorkService;
        public ClassCommandHandler(IMapper mapper, IUnitOfWorkService unitOfWorkService) { 
        
            this.mapper=mapper;

            this.unitOfWorkService=unitOfWorkService;


        }
        public Task<RESPONSE<Class>> Handle(AddClassCommand request, CancellationToken cancellationToken)
        {
          var c=  this.mapper.Map<Class>(request);

            this.unitOfWorkService.classService.Create(c);

            return RequestHandler<Class>.Success(c,"class is added successfuly");
        }

        public async Task<RESPONSE<Class>> Handle(UpdateClassCommand request, CancellationToken cancellationToken)
        {
            var c = this.mapper.Map<Class>(request);

           await this.unitOfWorkService.classService.Update(c);

            return await RequestHandler<Class>.Success(c,"Class Updated Successfull");
        }

        public async Task<RESPONSE<Class>> Handle(DeleteClassCommand request, CancellationToken cancellationToken)
        {
            //var c= await  this.unitOfWorkService.classService.Delete(request.Id);

            //   return await RequestHandler<Class>.Success(c,"class deleted successfull");

            return null;
        }
    }
}
