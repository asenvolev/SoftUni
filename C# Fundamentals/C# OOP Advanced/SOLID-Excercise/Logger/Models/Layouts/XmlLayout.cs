namespace Logger.Models
{
    using System;
    using Interfaces;
    using System.Text;
    public class XmlLayout : ILayout
    {
        public string DisplayLog(string dateAndTime, string reportLevel, string message)
        {
            var sb = new StringBuilder();
            sb.Append($"<log>" + Environment.NewLine)
                .Append($"   <date>{dateAndTime}</date>" + Environment.NewLine)
                .Append($"   <level>{reportLevel}</level>" + Environment.NewLine)
                .Append($"   <message>{message}</message>" + Environment.NewLine)
                .Append($"</log>" + Environment.NewLine);
            return sb.ToString();
        }
    }
}
