namespace Logger.Models
{
    using System;
    using Interfaces;
    using Enums;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout):base(layout)
        {
            
        }
        
        public override void Append(string dateAndTime, string reportLevel, string message)
        {
            this.Count++;
            ReportLevel currRepLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevel, true);
            if (currRepLevel>=this.ReportLevel)
            {
                Console.WriteLine(this.layout.DisplayLog(dateAndTime, reportLevel, message));
            }
        }
    }
}