using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.Identity.Client;
using SMS.Data.Entities;
using SMS.Infrastructure.DbContext;
using SMS.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.Repositories.Repos
{
    public class DepartmentRepo : GenericRepo<Department>, IDepartmentRepo
    {
        private readonly ApplicationDbContext context;

        public DepartmentRepo(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }
        public async Task<List<Department>> GetDepartmentsWithSuperVisor()
        {
            var Departments = (from Department in this.context.Departments
                              join Supervisor in this.context.Users
                              on Department.superVisorId equals Supervisor.Id
                              select Department).ToList();

            return await Task.FromResult( Departments);


        }

       public async Task<List<dynamic>> NumberOfTeacherInEveryDepartment()
        {


            var t = await (from department in this.context.Departments
                    select new 
                    {
                     DepartmentName = department.Name,
                        TeacherCount = department.teachers.Count(),

                    }).ToListAsync();
            return t.Cast<dynamic>().ToList();
                
        }

    }
}
