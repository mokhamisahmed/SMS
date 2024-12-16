using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.Repositories.Interfaces
{
    public interface IDepartmentRepo:IGenericRepo<Department>
    {
        public Task<List<Department>> GetDepartmentsWithSuperVisor();



    }
}
