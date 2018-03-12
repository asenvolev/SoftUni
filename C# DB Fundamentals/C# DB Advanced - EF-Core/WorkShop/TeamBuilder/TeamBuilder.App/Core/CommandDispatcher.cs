namespace TeamBuilder.App.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TeamBuilder.App.Core.Commands;

    public class CommandDispatcher
    {
        public string Dispatch(string input)
        {
            string result = string.Empty;

            string[] inputArgs = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            string commandName = inputArgs.Length > 0 ? inputArgs[0] : string.Empty;

            inputArgs = inputArgs.Skip(1).ToArray();

            switch (commandName)
            { 
                default:
                    throw new NotSupportedException($"Command {commandName} not supported!");
                case "Exit":
                    ExitCommand exit = new ExitCommand();
                    exit.Execute(inputArgs);
                    break;
                case "RegisterUser":
                    var reg = new RegisterUserCommand();
                    reg.Execute(inputArgs);
                    break;
                case "Login":
                    var Login = new LoginCommand();
                    Login.Execute(inputArgs);
                    break;
                case "Logout":
                    var Logout = new LogoutCommand();
                    Logout.Execute(inputArgs);
                    break;
                case "DeleteUser":
                    var DeleteUser = new DeleteUserCommand();
                    DeleteUser.Execute(inputArgs);
                    break;
            }

            return result;
        }
    }
}
