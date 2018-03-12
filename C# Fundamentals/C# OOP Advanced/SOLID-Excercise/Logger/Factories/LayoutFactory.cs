namespace Logger.Factories
{
    using System;
    using Interfaces;
    using Models;
    using System.Reflection;
    using System.Linq;

    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutName)
        {
            Type layoutType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == layoutName);
            return (ILayout)Activator.CreateInstance(layoutType);
        }
    }
}
