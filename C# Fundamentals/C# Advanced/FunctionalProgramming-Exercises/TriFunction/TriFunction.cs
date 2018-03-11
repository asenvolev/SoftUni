using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(Console.ReadLine().Split().Select(x =>
            {
                var namechar = x.ToString().ToCharArray();
                int result = 0;
                for (int i = 0; i < namechar.Length; i++)
                {
                    result += namechar[i];
                }
                string name = new string(namechar);
                return new { name, result };
            }).Where(x => x.result >= number).Select(x=>x.name).ToList().First());

        }
    }
}
