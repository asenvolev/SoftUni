﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BashSoft.Exceptions;

namespace BashSoft.IO.Commands
{
    public class OrderAndTakeCommand:Command
    {
        public OrderAndTakeCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {

        }

        public override void Execute()
        {
            if (this.Data.Length != 5)
            {
                throw new InvalidCommandException(this.Input);
            }
            var courseName = this.Data[1];
            var comparison = this.Data[2].ToLower();
            var takeCommand = this.Data[3].ToLower();
            var takeQuantity = this.Data[4].ToLower();

            TryParseParametersForOrderAndTake(takeCommand, takeQuantity, courseName, comparison);
        }
        private void TryParseParametersForOrderAndTake(string takeCommand, string takeQuantity, string courseName, string comparison)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    this.Repository.OrderAndTake(courseName, comparison, null);
                }
                else
                {
                    int studentsToTake;
                    var hasParsed = int.TryParse(takeQuantity, out studentsToTake);
                    if (hasParsed)
                    {
                        this.Repository.OrderAndTake(courseName, comparison, studentsToTake);
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
