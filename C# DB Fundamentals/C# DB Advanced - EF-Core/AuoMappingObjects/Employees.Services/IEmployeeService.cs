namespace Employees.Services
{
    using Employees.Models;
    using Employess.DtoModels;
    using System.Collections.Generic;

    public interface IEmployeeService
    {
        EmployeeDto GetEmployeeById(int employeeId);

        void AddEmployee(string firstName, string lastName, decimal salary);

        void SetBirthDay(int employeeId, string date);

        void SetAddress(int employeeId, string address);

        Employee GetEmployeePersonalInfo(int employeeId);

        void SetManager(int employeeId, int managerId);

        ManagerDto ManagerInfo(int employeeId);

        List<Employee> ListEmployeesOlderThanAge(int age);
    }
}
