using Microsoft.EntityFrameworkCore;
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
    public class ExamTypeRepo:GenericRepo<ExamType>,IExamTypeRepo
    {

        private readonly ApplicationDbContext context;
        public ExamTypeRepo(ApplicationDbContext context):base(context)
        {
        

        }
        public async Task<List<dynamic>> GetExamCountByType()
        {

            var examCounts = await this.context.ExamTypes.Select(
                type => new
                {

                    ExamTypeName = type.type,
                    ExamCount = type.exams.Count
                }).ToListAsync();

            return examCounts.Cast<dynamic>().ToList();

        }

    }
}
