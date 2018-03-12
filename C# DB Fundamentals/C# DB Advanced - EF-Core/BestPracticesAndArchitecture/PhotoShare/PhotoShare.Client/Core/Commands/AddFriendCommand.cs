namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Models;
    using Data;

    public class AddFriendCommand
    {
        // AddFriend <username1> <username2>
        public static string Execute(string[] data)
        {
            string senderUsername = data[0];
            string recieverUsername = data[1];

            if (Session.User == null)
            {
                throw new InvalidOperationException($"Invalid credentials!");
            }

            using (var context = new PhotoShareContext())
            {
                if (context.Users.SingleOrDefault(x => x.Username == senderUsername)==null)
                {
                    throw new ArgumentException($"{senderUsername} not found!");
                }

                var senderUser = context.Users.SingleOrDefault(x => x.Username == senderUsername);

                if (context.Users.SingleOrDefault(x => x.Username == recieverUsername) == null)
                {
                    throw new ArgumentException($"{recieverUsername} not found!");
                }

                var recieverUser = context.Users.SingleOrDefault(x => x.Username == recieverUsername);

                if (senderUser.FriendsAdded.Any(x=>x.Friend == recieverUser) &&
                    !recieverUser.FriendsAdded.Any(x => x.Friend == senderUser))
                {
                    throw new InvalidOperationException($"Friend request already sent!");
                }

                if (senderUser.FriendsAdded.Any(x => x.Friend == recieverUser) &&
                    recieverUser.FriendsAdded.Any(x => x.Friend == senderUser))
                {
                    throw new InvalidOperationException($"{recieverUsername} is already a friend to {senderUsername}");
                }

                if (!senderUser.FriendsAdded.Any(x => x.Friend == recieverUser) &&
                    recieverUser.FriendsAdded.Any(x => x.Friend == senderUser))
                {
                    throw new InvalidOperationException($"{senderUsername} has already recieved a friend request from {recieverUsername}");
                }

                var friendship = new Friendship()
                {
                    User = senderUser,
                    Friend = recieverUser
                };
                if (context.Friendships.Any(x=>x.User == senderUser && x.Friend == recieverUser))
                {
                    throw new InvalidOperationException($"{recieverUsername} is already a friend to {senderUsername}");
                }

                context.Friendships.Add(friendship);
                senderUser.FriendsAdded.Add(friendship);
                recieverUser.AddedAsFriendBy.Add(friendship);
                context.SaveChanges();

                return $"Friend {recieverUsername} added to {senderUsername}";
            }
        }
    }
}
