using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            var inputFile = "Input.txt";
            var lines = File.ReadAllLines(inputFile);
            var listOfLines = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                listOfLines.Add($"{i + 1}. {lines[i]}");
            }
            File.WriteAllLines("Output.txt", listOfLines);
        }
    }
}
