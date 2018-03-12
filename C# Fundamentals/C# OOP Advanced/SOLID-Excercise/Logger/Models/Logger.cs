namespace Logger.Models
{
    using System;
    using Interfaces;
    using System.Text;

    public class Logger : ILogger
    {
        private IAppender[] appenders;
        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void CallAppenders(string dateAndTime, string reportLevel, string message)
        {
            foreach (var appender in appenders)
            {
                appender.Append(dateAndTime, reportLevel, message);
            }
        }

        public void Error(string dateAndTime, string message)
        {
            string reportLevel = nameof(Error);
            CallAppenders(dateAndTime, reportLevel, message);
        }

        public void Info(string dateAndTime, string message)
        {
            string reportLevel = nameof(Info);
            CallAppenders(dateAndTime, reportLevel, message);
        }

        public void Warning(string dateAndTime, string message)
        {
            string reportLevel = "Warning";
            CallAppenders(dateAndTime, reportLevel, message);
        }

        public void Fatal(string dateAndTime, string message)
        {
            string reportLevel = nameof(Fatal);
            CallAppenders(dateAndTime, reportLevel, message);
        }

        public void Critical(string dateAndTime, string message)
        {
            string reportLevel = nameof(Critical);
            CallAppenders(dateAndTime, reportLevel, message);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Logger info");
            foreach (IAppender appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString();
        }
    }
}
