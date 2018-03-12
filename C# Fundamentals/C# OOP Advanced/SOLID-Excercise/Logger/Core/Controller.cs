using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Core
{
    using Models;
    using Interfaces;
    using Factories;
    using Enums;
    using System.Globalization;
    using System.Reflection;

    public class Controller
    {
        private AppenderFactory appenderFactory;
        private LayoutFactory layoutFactory;
        private ILogger logger;

        public Controller(AppenderFactory appenderFactory, LayoutFactory layoutFactory)
        {
            this.appenderFactory = appenderFactory;
            this.layoutFactory = layoutFactory;
        }

        public IAppender[] ReadAllAppenders()
        {
            int numOfAppenders = int.Parse(Console.ReadLine());
            IAppender[] appenders = new IAppender[numOfAppenders];
            for (int i = 0; i < numOfAppenders; i++)
            {
                string[] appenderTokens = Console.ReadLine().Split();
                ILayout currLayout = layoutFactory.CreateLayout(appenderTokens[1]);
                appenders[i] = appenderFactory.CreateAppender(appenderTokens[0], currLayout);
                if (appenderTokens.Length > 2)
                {
                    appenders[i].ReportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), appenderTokens[2], true);
                }
            }
            return appenders;
        }
       
        public void StartReadingLogs()
        {
            this.logger = new Logger(ReadAllAppenders());
            var input = Console.ReadLine();
            while (input != "END")
            {
                var loginfo = input.Split('|');
                string methodName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(loginfo[0].ToLower());
                string dateTime = loginfo[1];
                string message = loginfo[2];

                MethodInfo currMethod = typeof(Logger).GetMethod(methodName);
                currMethod.Invoke(logger, new object[] { dateTime, message });

                input = Console.ReadLine();
            }
        }
        public string GetLoggerInfo()
        {
            return this.logger.ToString();
        }
    }
}
