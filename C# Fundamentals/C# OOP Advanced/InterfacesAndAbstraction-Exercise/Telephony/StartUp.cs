using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var phones = Console.ReadLine().Split();
            var smartphone = new Smartphone();
            foreach (var phone in phones)
            {
                try
                {
                    Console.WriteLine(smartphone.Call(phone));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            var urls = Console.ReadLine().Split();
            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(url));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
