namespace PhotoShare.Client.Core
{
    using System;
    using System.Reflection;
    using System.Linq;
    using PhotoShare.Client.Core.Commands;

    public class CommandDispatcher
    {
        public string DispatchCommand(string[] commandParameters)
        {
            string command = commandParameters[0];
            var argumeents = commandParameters.Skip(1).ToArray();

            switch (command)
            {
                default:
                    throw new InvalidOperationException($"Command {command} not valid!");
                case "RegisterUser":
                    return RegisterUserCommand.Execute(argumeents);
                case "ModifyUser":
                    return ModifyUserCommand.Execute(argumeents);
                case "AddTown":
                    return AddTownCommand.Execute(argumeents);
                case "UploadPicture":
                    return UploadPictureCommand.Execute(argumeents);
                case "CreateAlbum":
                    return CreateAlbumCommand.Execute(argumeents);
                case "DeleteUser":
                    return DeleteUser.Execute(argumeents);
                case "AddTag":
                    return AddTagCommand.Execute(argumeents);
                case "AddTagTo":
                    return AddTagToCommand.Execute(argumeents);
                case "MakeFriends":
                    return AddFriendCommand.Execute(argumeents);                    
                case "ListFriends":
                    return PrintFriendsListCommand.Execute(argumeents);
                case "ShareAlbum":
                    return ShareAlbumCommand.Execute(argumeents);
                case "Exit":
                    return ExitCommand.Execute();
                case "Login":
                    return LoginCommand.Execute(argumeents);
                case "Logout":
                    return LogoutCommand.Execute();
            }
        }
    }
}
