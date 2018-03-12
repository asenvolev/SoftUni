namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Models;
    using Data;

    public class AcceptFriendCommand
    {
        // AcceptFriend <username1> <username2>
        public static string Execute(string[] data)
        {
            string acceptingUsername = data[0];
            string requestingUsername = data[1];

            if (Session.User == null)
            {
                throw new InvalidOperationException($"Invalid credentials!");
            }

            using (var context = new PhotoShareContext())
            {

                if (context.Users.SingleOrDefault(x => x.Username == acceptingUsername) == null)
                {
                    throw new ArgumentException($"{acceptingUsername} not found!");
                }

                var acceptingUser = context.Users.SingleOrDefault(x => x.Username == acceptingUsername);

                if (context.Users.SingleOrDefault(x => x.Username == requestingUsername) == null)
                {
                    throw new ArgumentException($"{requestingUsername} not found!");
                }

                var requestingUser = context.Users.SingleOrDefault(x => x.Username == requestingUsername);

                if (!requestingUser.FriendsAdded.Any(x => x.Friend == acceptingUser))
                {
                    throw new InvalidOperationException($"{requestingUsername} has not added {acceptingUsername} as a friend");
                }

                if (acceptingUser.FriendsAdded.Any(x => x.Friend == requestingUser) &&
                    requestingUser.FriendsAdded.Any(x => x.Friend == acceptingUser))
                {
                    throw new InvalidOperationException($"{requestingUsername} is already a friend to {acceptingUsername}");
                }

                if (!acceptingUser.AddedAsFriendBy.Any(x => x.Friend == requestingUser) &&
                    requestingUser.FriendsAdded.Any(x => x.Friend == acceptingUser))
                {
                    throw new InvalidOperationException($"{acceptingUsername} has already recieved a friend request from {requestingUsername}");
                }

                var friendship = context.Friendships.SingleOrDefault(x => x.User == requestingUser);
                acceptingUser.AddedAsFriendBy.Add(friendship);
                acceptingUser.FriendsAdded.Add(friendship);
                context.SaveChanges();

                return $"Friend {acceptingUsername} accepted {requestingUsername} as friend";
            }
        }
    }
}
