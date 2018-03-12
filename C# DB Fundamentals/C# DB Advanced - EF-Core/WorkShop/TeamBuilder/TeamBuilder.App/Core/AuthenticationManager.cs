namespace TeamBuilder.App.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using TeamBuilder.App.Utilities;
    using TeamBuilder.Models;

    public class AuthenticationManager
    {
        private static User currentUser { get; set; }

        public static void Login(User user)
        {
            currentUser = user;
        }

        public static void Logout()
        {
            if (currentUser == null)
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }
            currentUser = null;
        }

        public static void Authorize()
        {
            if (currentUser == null)
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }
        }

        public static bool IsAuthenticated()
        {
            return currentUser != null;
        }

        public static User GetCurrentUser()
        {
            if (currentUser == null)
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }

            return currentUser;
        }
    }
}
