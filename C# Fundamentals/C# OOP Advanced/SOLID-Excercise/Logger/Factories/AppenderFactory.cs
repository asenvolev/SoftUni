namespace Logger.Factories
{
    using System;
    using Interfaces;
    using Models;
    using System.Reflection;
    using System.Linq;

    public class AppenderFactory
    {
        public IAppender CreateAppender(string appenderName, ILayout layout)
        { 
            Type appenderType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == appenderName);
            return (IAppender)Activator.CreateInstance(appenderType, layout);
        }
    }
}
