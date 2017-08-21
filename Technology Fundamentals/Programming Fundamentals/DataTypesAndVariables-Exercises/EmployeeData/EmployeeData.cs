using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());
            char male = char.Parse(Console.ReadLine());
            long ID = long.Parse(Console.ReadLine());
            uint uniqueEmployeeNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {male}\nPersonal ID: {ID}\nUnique Employee number: {uniqueEmployeeNumber}");
        }
    }
}
