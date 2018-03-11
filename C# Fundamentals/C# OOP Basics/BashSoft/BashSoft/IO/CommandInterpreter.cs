using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BashSoft.Exceptions;
using BashSoft.IO.Commands;


namespace BashSoft
{
    public class CommandInterpreter
    {
        private Tester judge;
        private StudentsRepository repository;
        private IOManager inputOutputManager;

        private void TryDropDb(string input, string[] data)
        {
            if (data.Length != 1)
            {
                throw new InvalidCommandException(input);
            }
            this.repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }
        public CommandInterpreter(Tester judge, StudentsRepository repository, IOManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }
        public void InterpredCommand(string input)
        {
            string[] data = input.Split();
            string commandName = data[0];
            try
            {
                Command command = this.Parsecommand(input, commandName, data);
                command.Execute();
            }
            catch(DirectoryNotFoundException dnfe)
            {
                OutputWriter.DisplayException(dnfe.Message);
            }
            catch(ArgumentOutOfRangeException aoore)
            {
                OutputWriter.DisplayException(aoore.Message);
            }
            catch (ArgumentException ae)
            {
                OutputWriter.DisplayException(ae.Message);
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }
        }

        private Command Parsecommand(string input, string command, string[] data)
        {
            switch (command)
            {
                case "open":
                    return new OpenFileCommand(input, data,this.judge,this.repository,this.inputOutputManager);
                case "mkdir":
                    return new CreateDirectoryCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "ls":
                    return new TraverseFoldersCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "cmp":
                    return new CompareFilesCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "cdRel":
                    return new ChangePathRelativelyCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "cdAbs":
                    return new ChangePathAbsoluteCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "readDb":
                    return new ReadDataBaseFromFileCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "help":
                    return new GetHelpCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "filter":
                    return new FilterAndTakeCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "order":
                    return new OrderAndTakeCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                case "decOrder":
                    throw new InvalidCommandException(input);
                case "download":
                    throw new InvalidCommandException(input);
                case "downloadAsynch":
                    throw new InvalidCommandException(input);
                case "show":
                    return new ShowWantedDataCommand(input, data, this.judge, this.repository, this.inputOutputManager);
                default:
                    throw new InvalidCommandException(input);
            }
        }
    }
}
