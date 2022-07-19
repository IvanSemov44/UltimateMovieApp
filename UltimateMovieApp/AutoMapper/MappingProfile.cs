﻿using AutoMapper;
using Entities.DataTransferObjects.Company;
using Entities.DataTransferObjects.Employee;
using Entities.Models;

namespace UltimateMovieApp.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompaniesDto>()
                .ForMember(c => c.FullAddress,
                opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            CreateMap<Employee, EmployeeDto>();

            CreateMap<CompanyForCreationDto, Company>();

            CreateMap<EmployeeForCreationDto, Employee>();


            CreateMap<EmployeeForUpdateDto, Employee>();

            CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();

            CreateMap<CompanyForUpdateDto, Company>();
        }
    }
}
