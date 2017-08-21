using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderSize
{
    class FolderSize
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("TestFolder").Select(f => new FileInfo(f)).Sum(f => f.Length);
            double maikaTi = (files/1024.0)/1024;
            File.WriteAllText("Output.txt", maikaTi.ToString());
        }
    }
}
