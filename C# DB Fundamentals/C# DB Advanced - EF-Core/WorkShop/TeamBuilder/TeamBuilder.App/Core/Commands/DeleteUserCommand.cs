namespace TeamBuilder.App.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TeamBuilder.App.Utilities;
    using TeamBuilder.Data;
    using TeamBuilder.Models;

    public class DeleteUserCommand
    {
        public string Execute(string[] inputArgs)
        {
            Check.CheckLength(0, inputArgs);

            AuthenticationManager.Authorize();

            User user = AuthenticationManager.GetCurrentUser();

            using (var context = new TeamBuilderContext())
            {
                context.Users.SingleOrDefault(u => u.Username == user.Username).IsDeleted = true;
                context.SaveChanges();
            }

            AuthenticationManager.Logout();

            return $"User {user.Username} was deleted successfully!";
        }
    }
}
