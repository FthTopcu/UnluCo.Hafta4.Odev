using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Hafta2.Odev.Application.SchoolOperations.Queries.GetSchoolDetail;
using UnluCo.Hafta2.Odev.Application.SchoolOperations.Queries.GetSchools;
using UnluCo.Hafta2.Odev.Entities;
using static UnluCo.Hafta2.Odev.Application.SchoolOperations.Commands.CreateSchool.CreateSchoolCommand;

namespace UnluCo.Hafta2.Odev.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateSchoolModel, School>();
            CreateMap<School, SchoolsViewModel>();
            CreateMap<School, SchoolDetailViewModel>();
        }
    }
}
