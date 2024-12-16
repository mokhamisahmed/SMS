using AutoMapper;
using FluentValidation;
using MediatR;
using SMS.Core.Bases;
using SMS.Core.Features.DepartmentCore.Command.Entities;
using SMS.Core.UnitOfWorkValidation;
using SMS.Core.Validations;
using SMS.Data.Entities;
using SMS.Service.UnitOfWorkService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Features.DepartmentCore.Command.Handlers
{
    public class DepartmentCommandHandler : IRequestHandler<AddDepartmentCommand, RESPONSE<Department>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWorkValidation<Department> validation;
        private readonly IUnitOfWorkService workService;


        public DepartmentCommandHandler(IMapper mapper, IUnitOfWorkValidation<Department> validation, IUnitOfWorkService workService)
        {

            this.mapper = mapper;
            this.validation = validation;
            this.workService = workService;
        }
        public async Task<RESPONSE<Department>> Handle(AddDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = mapper.Map<Department>(request);

            validation.setValidation(new DepartmentValidation());

            var validationResult = validation.validator.Validate(department);

            if (!validationResult.IsValid)
            {
                return await RequestHandler<Department>.BadRequest(department, "there is validation error", validationResult.Errors);
            }

            try
            {
                await workService.departmentService.Create(department);

                return await RequestHandler<Department>.Success(department, "Department Created Successful");


            }
            catch (Exception ex)
            {

                var errorResponse = await RequestHandler<Department>.Error(department, "An error occurred while processing the request.", ex);

                return errorResponse;
            }




        }
    }
}
