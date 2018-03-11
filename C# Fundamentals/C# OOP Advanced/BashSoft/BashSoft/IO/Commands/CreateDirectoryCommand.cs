using BashSoft.Contracts;
using BashSoft.Exceptions;
using BashSoft.Attributes;

namespace BashSoft.IO.Commands
{
    [Alias("mkdir")]
    public class CreateDirectoryCommand : Command
    {
        [Inject]
        private IDirectoryManager inputOutputManager;
        public CreateDirectoryCommand(string input, string[] data)
            : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }
            var folderName = this.Data[1];
            this.inputOutputManager.CreateDirectoryInCurrentFolder(folderName);
        }
    }
}