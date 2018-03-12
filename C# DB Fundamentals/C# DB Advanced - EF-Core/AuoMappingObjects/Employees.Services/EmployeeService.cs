namespace Employees.Services
{
    using Employees.Data;
    using Employess.DtoModels;
    using System;
    using System.Globalization;
    using AutoMapper;
    using Employees.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeesDbContext context;

        public EmployeeService(EmployeesDbContext Context)
        {
            this.context = Context;
        }

        public void AddEmployee(string firstName, string lastName, decimal salary)
        {
            var employeeDto = new EmployeeDto()
            {
                FirstName = firstName,
                LastName = lastName,
                Salary = salary
            };

            var employee = Mapper.Map<Employee>(employeeDto);

            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public EmployeeDto GetEmployeeById(int employeeId)
        {
            var employee = context.Employees.Find(employeeId);

            var employeeDto = Mapper.Map<EmployeeDto>(employee);

            return employeeDto;
        }

        public Employee GetEmployeePersonalInfo(int employeeId)
        {
            var employee = context.Employees.Find(employeeId);

            return employee;
        }

        public ICollection<Employee> ListEmployeesOlderThanAge(int age)
        {
            var resultList = context.Employees
                .Where(x => x.BirthDay.Value.Year < DateTime.Now.Year - age)
                .OrderByDescending(x=>x.Salary)
                .ToList();

            return resultList;
        }

        public ManagerDto ManagerInfo(int employeeId)
        {
            var employee = context.Employees.Find(employeeId);

            var managerDto = Mapper.Map<ManagerDto>(employee);

            return managerDto;
        }

        public void SetAddress(int employeeId, string address)
        {
            var employee = context.Employees.Find(employeeId);

            employee.Address = address;

            context.SaveChanges();
        }

        public void SetBirthDay(int employeeId, string date)
        {
            DateTime parsedDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var employee = context.Employees.Find(employeeId);

            employee.BirthDay = parsedDate;

            context.SaveChanges();
        }

        public void SetManager(int employeeId, int managerId)
        {
            var employee = context.Employees.Find(employeeId);

            var manager = context.Employees.Find(managerId);

            manager.ManagedEmployees.Add(employee);

            employee.Manager = manager;
            employee.ManagerId = managerId;

            context.SaveChanges();
        }
    }
}
