using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core
{
    public class Engine
    {
        private Controller controller;
        public Engine(Controller controller)
        {
            this.controller = controller;
        }
        public void Run()
        {
            controller.StartReadingLogs();
            Console.WriteLine(controller.GetLoggerInfo());
        }
    }
}
