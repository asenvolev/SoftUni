using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(x => Enum.Parse(typeof(TrafficLight), x)).ToList();
            var numOfChanges = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            for (int i = 0; i < numOfChanges; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    input[j] = (TrafficLight)(((int)input[j] + 1)
                % Enum.GetNames(typeof(TrafficLight)).Length);
                }
                sb.AppendLine(string.Join(" ", input));
            }
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
