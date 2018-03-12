﻿namespace Logger.Interfaces
{
    using Enums;
    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        void Append(string dateAndTime, string reportLevel, string message);
    }
}
