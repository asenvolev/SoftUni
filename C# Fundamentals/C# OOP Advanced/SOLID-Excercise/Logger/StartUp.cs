namespace Logger
{
    using Core;
    using Factories;
    using Models;
    public class StartUp
    {
        public static void Main()
        {
            var appFact = new AppenderFactory();
            var layoutFact = new LayoutFactory();
            var controller = new Controller(appFact, layoutFact);
            var engine = new Engine(controller);
            engine.Run();

        }
    }
}
