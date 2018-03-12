namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Models;
    using Data;

    public class PrintFriendsListCommand 
    {
        // PrintFriendsList <username>
        public static string Execute(string[] data)
        {
            // TODO prints all friends of user with given username.
            string username = data[0];

            using (var context = new PhotoShareContext())
            {
                if (context.Users.SingleOrDefault(x => x.Username == username) == null)
                {
                    throw new ArgumentException($"{username} not found!");
                }

                var user = context.Users.SingleOrDefault(x => x.Username == username);

                var friends = user.FriendsAdded.Select(x => x.Friend.Username).ToList();

                if (friends.Count==0)
                {
                    return "No friends for this user.:(";
                }
                else
                {
                    return $"Friends:\r\n{string.Join(Environment.NewLine, friends)}";
                }
            }
        }
    }
}
