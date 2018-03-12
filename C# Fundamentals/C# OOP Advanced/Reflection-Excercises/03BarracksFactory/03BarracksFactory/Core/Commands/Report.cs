namespace _03BarracksFactory.Core.Commands
{
    using System;
    using Contracts;
    using Attributes;
    public class Report : Command
    {
        [Inject]
        private IRepository repository;
        public Report(string[] data):base(data)
        {

        }
        public override string Execute()
        {
            string output = this.repository.Statistics;
            return output;
        }
    }
}
