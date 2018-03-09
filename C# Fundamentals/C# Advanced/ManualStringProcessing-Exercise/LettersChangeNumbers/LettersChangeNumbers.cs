using System;
using System.Text;

namespace LettersChangeNumbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' ','\t','\n' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            double letterNum = 0;
            double currNum = 0;
            string mathFunc = string.Empty;
            var num = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var currWord = input[i];
                for (int j = 0; j < currWord.Length; j++)
                {
                    char currChar = currWord[j];
                    if (char.IsLetter(currChar))
                    {
                        
                        if (char.IsUpper(currChar))
                        {
                            
                            letterNum = currChar - 64;
                            mathFunc = "/";
                        }
                        else
                        {
                            letterNum = currChar - 96;
                            mathFunc = "*";
                        }
                    }
                    else
                    {
                        num.Append(currChar);
                        if (char.IsLetter(currWord[j + 1]))
                        {
                            currNum = int.Parse(num.ToString());
                            if (mathFunc == "/")
                            {
                                sum += currNum / letterNum;
                                letterNum = 0;
                            }
                            else
                            {
                                sum += currNum * letterNum;
                                letterNum = 0;
                            }
                        }
                    }
                    if (j == currWord.Length-1)
                    {
                        if (mathFunc == "/")
                        {
                            sum -= letterNum;
                            letterNum = 0;
                        }
                        else
                        {
                            sum +=letterNum;
                            letterNum = 0;
                        }
                        num.Clear();
                    }
                    
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
