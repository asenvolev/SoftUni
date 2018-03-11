using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string driver = Console.ReadLine();
            ICar ferrari = new Ferrari(driver);
            Console.WriteLine(ferrari);
            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}
