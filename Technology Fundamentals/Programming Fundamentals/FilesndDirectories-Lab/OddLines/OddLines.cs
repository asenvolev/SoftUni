using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            var inputFile = "Input.txt";
            var lines = File.ReadAllLines(inputFile);
            var listOfLines = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (i%2==1)
                {
                    listOfLines.Add(lines[i]);
                }
            }
            File.WriteAllLines("Output.txt", listOfLines);
        }
    }
}
