using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Interfaces
{
   public interface IClassService
    {
        public Task<int> Create(Class c);

        public Task<int> Update(Class c);

        //public Task<Class> Delete(int id);

    }
}
