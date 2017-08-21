using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            var firstFile = File.ReadAllLines("Input1.txt");
            var secondFile = File.ReadAllLines("Input2.txt");
            var mergedList = new List<string>();
            for (int i = 0; i < firstFile.Length; i++)
            {
                mergedList.Add(firstFile[i]);
                mergedList.Add(secondFile[i]);
            }
            File.WriteAllLines("Output.txt", mergedList);
        }
    }
}
