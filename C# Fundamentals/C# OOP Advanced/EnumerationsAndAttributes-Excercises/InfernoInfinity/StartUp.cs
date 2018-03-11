using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfernoInfinity
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CommandInterpreter commInter = new CommandInterpreter();
            commInter.StartReadingCommands();
        }
    }
}
