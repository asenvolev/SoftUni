﻿namespace BashSoft
{
    using BashSoft.Contracts;

    public class Launcher
    {
        private static void Main()
        {
            IContentComparer tester = new Tester();
            IDirectoryManager ioManager = new IOManager();
            IDatabase repo = new StudentsRepository(new RepositorySorter(), new RepositoryFilter());
            IInterpreter currentInterpreter = new CommandInterpreter(tester, repo, ioManager);
            IReader reader = new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}