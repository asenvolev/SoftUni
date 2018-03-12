using System;

using Instagraph.Data;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Xml.Linq;

namespace Instagraph.DataProcessor
{
    public class Serializer
    {
        public static string ExportUncommentedPosts(InstagraphContext context)
        {
            var posts = context.Posts
                .Where(x => x.Comments.Count == 0)
                .OrderBy(x=>x.Id)
                .Select(p => new
                {
                    Id = p.Id,
                    Picture = p.Picture.Path,
                    User = p.User.Username
                })
                .ToArray();

            return JsonConvert.SerializeObject(posts, Formatting.Indented);
            
        }

        public static string ExportPopularUsers(InstagraphContext context)
        {
            var users = context.Users
                     .Where(u => u.Posts
                         .Any(p => p.Comments
                             .Any(c => u.Followers
                                 .Any(f => f.FollowerId == c.UserId))))
                    .Select(x=>new { Username = x.Username, Followers = x.Followers.Count })
                    .ToArray();

            return JsonConvert.SerializeObject(users,Formatting.Indented);
        }

        public static string ExportCommentsOnPosts(InstagraphContext context)
        {
            var users = context.Users
                .Select(p => new
                {
                    MostComments = p.Posts.Select(x => x.Comments).Count(),
                    Username = p.Username
                })
                .OrderByDescending(x=>x.MostComments)
                .ThenBy(x=>x.Username)
                .ToArray();

            var xDoc = new XDocument(new XElement("users"));

            foreach (var user in users)
            {
                xDoc.Root.Add(new XElement("user",
                    new XElement("Username", user.Username),
                    new XElement("MostComments", user.MostComments)
                    ));
            }

            return xDoc.ToString();
        }
    }
}
