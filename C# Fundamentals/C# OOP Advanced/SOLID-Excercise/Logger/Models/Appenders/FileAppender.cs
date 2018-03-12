namespace Logger.Models
{
    using Interfaces;
    using Enums;
    using System;

    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout):base(layout)
        {
            this.File = new LogFile(); 
        }
        public LogFile File { get; set; }
        public override void Append(string dateAndTime, string reportLevel, string message)
        {
            this.Count++;
            string info = this.layout.DisplayLog(dateAndTime, reportLevel, message);
            ReportLevel currRepLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevel, true);
            if (currRepLevel >= this.ReportLevel)
            {
                File.Write(info);
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", File size: {this.File.Size}";
        }
    }
}