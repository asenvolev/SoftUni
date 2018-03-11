using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class CompanyRoster
    {
        static void Main(string[] args)
        {
            var numOfEmployees = int.Parse(Console.ReadLine());
            var persons = new List<Employee>();
            //var per = new Dictionary<string,List<Employee>>();
            for (int i = 0; i < numOfEmployees; i++)
            {
                var input = Console.ReadLine().Split();
                //if (!per.ContainsKey(input[3]))
                //{
                //    per.Add(input[3], new List<Employee>());
                //}
                if (input.Length == 5)
                {
                    int age;
                    if (int.TryParse(input[4], out age))
                    {
                        var employee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], age);
                        persons.Add(employee);
                    }
                    else
                    {
                        var employee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], input[4]);
                        persons.Add(employee);
                    }
                }
                else if (input.Length < 5)
                {
                    var employee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3]);
                    persons.Add(employee);
                }
                else
                {
                    var employee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], input[4], int.Parse(input[5]));
                    persons.Add(employee);
                }

            }

            var bestDep = persons.GroupBy(x => x.Department).Select(x => new
            {
                name = x.Key,
                average = x.Average(c => c.Salary),
                employees = x
            }).OrderByDescending(x=>x.average).FirstOrDefault();
            Console.WriteLine($"Highest Average Salary: {bestDep.name}");
            foreach (var em in bestDep.employees.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine(em.ToString());
            }
        }
    }
}
