namespace Logger.Models
{
    using System;
    using Interfaces;
    using System.Text;
    using System.Linq;
    using System.IO;

    public class LogFile : ILogFile
    {
        private const string DefaultFileName = "log.txt";
        private StringBuilder sb;

        public LogFile()
        {
            this.sb = new StringBuilder();
        }

        public int Size { get; private set; }

        public void Write(string message)
        {
            this.sb.Append(message + Environment.NewLine);
            this.Size += message
                .Where(c => char.IsLetter(c))
                .Sum(c => c);
            File.AppendAllText(DefaultFileName, message + Environment.NewLine);
        }
    }
}
