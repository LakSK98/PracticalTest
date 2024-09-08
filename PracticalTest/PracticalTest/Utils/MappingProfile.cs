using AutoMapper;
using PracticalTest.DTOs;
using PracticalTest.Models;

namespace PracticalTest.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping between Employee and EmployeeDto
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }
    }
}
