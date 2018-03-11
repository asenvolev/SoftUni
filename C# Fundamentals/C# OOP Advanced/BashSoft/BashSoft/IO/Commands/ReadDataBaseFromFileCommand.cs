using BashSoft.Contracts;
using BashSoft.Exceptions;
using BashSoft.Attributes;

namespace BashSoft.IO.Commands
{
    [Alias("readDb")]
    public class ReadDataBaseFromFileCommand : Command
    {
        [Inject]
        private IDatabase repository;
        public ReadDataBaseFromFileCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }
            var databasePath = this.Data[1];
            this.repository.LoadData(databasePath);
        }
    }
}