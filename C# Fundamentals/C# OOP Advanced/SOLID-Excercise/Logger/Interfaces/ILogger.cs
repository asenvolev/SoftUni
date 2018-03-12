using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Interfaces
{
    public interface ILogger
    {
        void Error(string dateAndTime, string message);
        void Info(string dateAndTime, string message);
        void Warning(string dateAndTime, string message);
        void Fatal(string dateAndTime, string message);
        void Critical(string dateAndTime, string message);
    }
}
