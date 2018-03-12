﻿namespace _03BarracksFactory
{
    using Contracts;
    using Core;
    using Core.Factories;
    using Core.Commands;
    using Data;

    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            ICommandInterpreter interpreter = new Interpeter(repository, unitFactory);
            IRunnable engine = new Engine(interpreter);
            engine.Run();
        }
    }
}
