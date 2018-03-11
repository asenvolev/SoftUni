﻿using BashSoft.Contracts;
using BashSoft.Exceptions;
using BashSoft.Attributes;
namespace BashSoft.IO.Commands
{
    [Alias("cdAbs")]
    public class ChangePathAbsoluteCommand : Command
    {
        [Inject]
        private IDirectoryManager InputOutputManager;
        public ChangePathAbsoluteCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }
            var absPath = this.Data[1];
            this.InputOutputManager.ChangeCurrentDirectoryAbsolute(absPath);
        }
    }
}