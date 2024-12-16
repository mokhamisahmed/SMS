using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Interfaces
{
    public interface IDepartmentService
    {
        public Task<int> Create(Department department);
            
    }
}
