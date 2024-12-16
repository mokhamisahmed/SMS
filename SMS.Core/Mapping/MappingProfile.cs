using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SMS.Core.Features.ClassCore.Command.Entities;
using SMS.Core.Features.DepartmentCore.Command.Entities;
using SMS.Core.Features.ExamTypeCore.Entities;
using SMS.Core.Features.LevelCore.Entities;
using SMS.Core.Features.RoleCore.Command.Entities;
using SMS.Core.Features.SubjectCore.Entities;
using SMS.Core.Features.TeacherCore.Entities;
using SMS.Core.Features.UserCore.Command.Entities;
using SMS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Core.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AddDepartmentCommand, Department>().ReverseMap();
            CreateMap<AddRoleCommand,IdentityRole>().ReverseMap();
            CreateMap<Class,AddClassCommand>().ReverseMap();
            CreateMap<AddUserCommand, ApplicationUser>().ReverseMap();
            CreateMap<AddLevelCommand, Level>().ReverseMap();
            CreateMap<AddTeacherCommand, Teacher>().ReverseMap();
            CreateMap<AddSubjectCommand,Subject>().ReverseMap();
            CreateMap<AddExamTypeCommand, ExamType>().ReverseMap();
        }




    }
}
