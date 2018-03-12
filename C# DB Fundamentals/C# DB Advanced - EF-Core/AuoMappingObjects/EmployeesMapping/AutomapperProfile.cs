namespace Employees.App
{
    using AutoMapper;
    using Employees.Models;
    using Employess.DtoModels;

    class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeDto, Employee>();
            CreateMap<Employee, ManagerDto>();
            CreateMap<ManagerDto, Employee>();
        }
    }
}
