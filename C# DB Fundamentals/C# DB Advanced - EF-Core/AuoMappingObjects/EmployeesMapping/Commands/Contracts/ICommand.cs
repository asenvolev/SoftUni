namespace Employees.App.Commands.Contracts
{
    public interface ICommand
    {
        string Execute(string[] args);
    }
}
