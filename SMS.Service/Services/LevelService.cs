using SMS.Data.Entities;
using SMS.Infrastructure.UnitOfWork;
using SMS.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Service.Services
{
    public class LevelService : ILevelService
    {
        private readonly IUnitOfWork<Level> unitOfWork;

        public LevelService(IUnitOfWork<Level> unitOfWork)
        {

            this.unitOfWork = unitOfWork;

        }
        public async Task<int> Create(Level level)
        {
           await this.unitOfWork.genericRepo.Create(level);
          return await this.unitOfWork.Complete();
        }
    }
}
