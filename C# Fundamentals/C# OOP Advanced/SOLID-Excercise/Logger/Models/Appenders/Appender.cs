namespace Logger.Models
{
    using System;
    using Interfaces;
    using Enums;
    using System.Text;

    public abstract class Appender : IAppender
    {
        protected ILayout layout;
        public Appender(ILayout layout)
        {
            this.layout = layout;
        }
        public int Count { get; set; }
        public ReportLevel ReportLevel { get; set; }
        public abstract void Append(string dateAndTime, string reportLevel, string message);
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append($"Appender type: {this.GetType().Name}, ")
                .Append($"Layout type: {this.layout.GetType().Name}, ")
                .Append($"Report level: {this.ReportLevel.ToString().ToUpper()}, ")
                .Append($"Message appended: {this.Count}")
                .ToString();
        }
    }
}
