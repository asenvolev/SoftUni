namespace _03BarracksFactory.Core.Commands
{
    using System;
    using Contracts;
    public abstract class Command : IExecutable
    {
        private string[] data;
        
        public Command(string[] data)
        {
            this.Data = data;
        }

        public string[] Data
        {
            get{return this.data;}
            set{this.data = value;}
        }

        
        public abstract string Execute();
    }
}
