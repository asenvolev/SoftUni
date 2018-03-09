using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonousPlants
{
    class PoisonousPlants
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var daysPlantsDies = new int[n];
            var stackPlants = new Stack<int>();
            stackPlants.Push(0);
            for (int i = 1; i < n; i++)
            {
                int lastDay = 0;
                while (stackPlants.Count>0 && plants[stackPlants.Peek()] >= plants[i])
                {
                    lastDay = Math.Max(lastDay, daysPlantsDies[stackPlants.Pop()]);
                    
                }
                if (stackPlants.Count > 0)
                {
                    daysPlantsDies[i] = lastDay + 1;
                }
                stackPlants.Push(i);
            }
            Console.WriteLine(daysPlantsDies.Max());
            
        }
    }
}
