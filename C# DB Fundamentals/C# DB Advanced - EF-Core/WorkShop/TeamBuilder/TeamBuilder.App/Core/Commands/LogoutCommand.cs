﻿namespace TeamBuilder.App.Core.Commands
{
    using System;
    using TeamBuilder.App.Utilities;
    using TeamBuilder.Models;

    public class LogoutCommand
    {
        public string Execute(string[] inputArgs)
        {
            Check.CheckLength(0, inputArgs);

            AuthenticationManager.Authorize();

            User user = AuthenticationManager.GetCurrentUser();

            AuthenticationManager.Logout();

            return $"User {user.Username} successfully logged out!";
        }
    }
}
