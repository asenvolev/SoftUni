﻿using BashSoft.Contracts;
using BashSoft.Exceptions;
using BashSoft.Attributes;

namespace BashSoft.IO.Commands
{
    [Alias("filter")]
    public class FilterAndTakeCommand : Command
    {
        [Inject]
        private IDatabase repository;
        public FilterAndTakeCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 5)
            {
                throw new InvalidCommandException(this.Input);
            }
            var courseName = this.Data[1];
            var filter = this.Data[2].ToLower();
            var takeCommand = this.Data[3].ToLower();
            var takeQuantity = this.Data[4].ToLower();

            TryParseParametersForFilterAndTake(takeCommand, takeQuantity, courseName, filter);
        }

        private void TryParseParametersForFilterAndTake(string takeCommand, string takeQuantity, string courseName, string filter)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    this.repository.FilterAndTake(courseName, filter, null);
                }
                else
                {
                    int studentsToTake;
                    var hasParsed = int.TryParse(takeQuantity, out studentsToTake);
                    if (hasParsed)
                    {
                        this.repository.FilterAndTake(courseName, filter, studentsToTake);
                    }
                    else
                    {
                        throw new InvalidTakeQueryParameter();
                    }
                }
            }
            else
            {
                throw new InvalidTakeQueryParameter();
            }
        }
    }
}