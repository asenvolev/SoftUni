namespace TeamBuilder.App
{
    using System;
    using Core;

    public class Application
    {
        public static void Main()
        {
            var engine = new Engine(new CommandDispatcher());
            engine.Run();
        }
    }
}
