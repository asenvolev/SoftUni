namespace _03BarracksFactory.Core.Commands
{
    using System;
    using Contracts;
    using Attributes;
    public class Retire:Command
    {
        [Inject]
        private IRepository repository;

        public Retire(string[] data)
            :base(data)
        {

        }
        public override string Execute()
        {
            var result = string.Empty;
            var unitType = this.Data[1];
            try
            {
                this.repository.RemoveUnit(unitType);
                result = $"{unitType} retired!";
            }
            catch (InvalidOperationException e)
            {
                result = e.Message;
            }

            return result;
        }
    }
}
