using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var firstWord = input[0].ToCharArray();
            var secondWord = input[1].ToCharArray();
            int minVal = Math.Min(firstWord.Length, secondWord.Length);
            int totalSum = 0;
            
            for (int i = 0; i < minVal; i++)
            {
                int firstNum = firstWord[i];
                int secNum = secondWord[i];
                totalSum += firstNum * secNum;
            }
            
            if (minVal == firstWord.Length)
            {
                
                for (int i = minVal; i < secondWord.Length ; i++)
                {
                    totalSum += secondWord[i];
                }
            }
            else
            {
                for (int i = minVal; i < firstWord.Length; i++)
                {
                    totalSum += firstWord[i];
                }
            }
            Console.WriteLine(totalSum);

        }
    }
}
