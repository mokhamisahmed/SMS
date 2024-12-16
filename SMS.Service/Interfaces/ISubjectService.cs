using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Interfaces
{
    public interface ISubjectService
    {

        public Task<int> Create(Subject subject);

    }
}
