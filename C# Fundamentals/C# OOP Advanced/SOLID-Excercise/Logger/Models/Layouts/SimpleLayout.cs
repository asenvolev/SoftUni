namespace Logger.Models
{
    using System;
    using Interfaces;
    public class SimpleLayout : ILayout
    {
        public string DisplayLog(string dateAndTime, string reportLevel, string message)
        {
            return string.Format($"{dateAndTime} - {reportLevel} - {message}");
        }
    }
}