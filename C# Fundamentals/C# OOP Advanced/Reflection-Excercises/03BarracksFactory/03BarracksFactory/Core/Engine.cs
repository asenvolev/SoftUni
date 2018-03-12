namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;
    using Commands;

    class Engine : IRunnable
    {
        private ICommandInterpreter interpreter;

        public Engine(ICommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string result = interpreter.InterpretCommand(data, data[0]).Execute();
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }               
    }
}
