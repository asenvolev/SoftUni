using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

using Newtonsoft.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

using Instagraph.Data;
using Instagraph.Models;
using Instagraph.DataProcessor.ImportDtos;

namespace Instagraph.DataProcessor
{
    public class Deserializer
    {
        public static string ImportPictures(InstagraphContext context, string jsonString)
        {
            Picture[] objects = JsonConvert.DeserializeObject<Picture[]>(jsonString);

            var sb = new StringBuilder();

            var picsToImport = new List<Picture>();

            foreach (var pic in objects)
            {
                if (string.IsNullOrWhiteSpace(pic.Path) || pic.Size<=0 || picsToImport.Any(p=>p.Path==pic.Path))
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                picsToImport.Add(new Picture()
                {
                    Path = pic.Path,
                    Size = pic.Size
                });

                sb.AppendLine($"Successfully imported Picture {pic.Path}.");
            }

            context.Pictures.AddRange(picsToImport);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportUsers(InstagraphContext context, string jsonString)
        {
            UserDto[] users = JsonConvert.DeserializeObject<UserDto[]>(jsonString);

            var sb = new StringBuilder();
            var validUsers = new List<User>();
            
            foreach (var user in users)
            {
                var picture = context.Pictures.SingleOrDefault(x => x.Path == user.ProfilePicture);

                if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.Password)
                    || validUsers.Any(p => p.Username == user.Username) || user.Username.Length>30 
                    || user.Password.Length > 20 || picture == null)
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                validUsers.Add(new User()
                {
                    Username = user.Username,
                    Password = user.Password,
                    ProfilePictureId = picture.Id,
                });
                sb.AppendLine($"Successfully imported User {user.Username}.");
            }
            context.Users.AddRange(validUsers);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportFollowers(InstagraphContext context, string jsonString)
        {
            UserFollowerDto[] userFolowers = JsonConvert.DeserializeObject<UserFollowerDto[]>(jsonString);

            var sb = new StringBuilder();
            var validUserFollowers = new List<UserFollower>();

            foreach (var userFol in userFolowers)
            {
                var user = context.Users.SingleOrDefault(x => x.Username == userFol.User);
                var follower = context.Users.SingleOrDefault(x => x.Username == userFol.Follower);
                
                if (user == null || follower == null || validUserFollowers.Any(x=>x.FollowerId == follower.Id && x.UserId==user.Id))
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                validUserFollowers.Add(new UserFollower()
                {
                    UserId = user.Id,
                    FollowerId = follower.Id
                });
                sb.AppendLine($"Successfully imported Follower {follower.Username} to User {user.Username}.");
            }

            context.AddRange(validUserFollowers);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportPosts(InstagraphContext context, string xmlString)
        {
            var xmlDoc = XDocument.Parse(xmlString);

            var sb = new StringBuilder();

            var validPosts = new List<Post>();

            foreach (var elem in xmlDoc.Root.Elements())
            {
                string caption = elem.Element("caption").Value;
                string username = elem.Element("user").Value;
                string pictPath = elem.Element("picture").Value;

                var picture = context.Pictures.SingleOrDefault(u => u.Path == pictPath);
                var user = context.Users.SingleOrDefault(u => u.Username == username);

                if (picture == null || user == null || caption == null)
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                var post = new Post()
                {
                    PictureId = picture.Id,
                    UserId = user.Id,
                    Caption = caption
                };
                validPosts.Add(post);
                sb.AppendLine($"Successfully imported Post {post.Caption}.");
            }
            context.Posts.AddRange(validPosts);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportComments(InstagraphContext context, string xmlString)
        {
            var xmlDoc = XDocument.Parse(xmlString);

            var sb = new StringBuilder();

            var validComments = new List<Comment>();

            foreach (var elem in xmlDoc.Root.Elements())
            {
                string content = elem.Element("content")?.Value;
                string username = elem.Element("user")?.Value;
                string postIdString = elem.Element("post")?.Attribute("id")?.Value;

                int postId;
                if(string.IsNullOrWhiteSpace(postIdString) ||
                    string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(content))
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }
                int.TryParse(postIdString, out postId);
                var post = context.Posts.SingleOrDefault(u => u.Id == postId);

                var user = context.Users.SingleOrDefault(u => u.Username == username);

                if (post == null || user == null || content == null || content.Length>250)
                {
                    sb.AppendLine("Error: Invalid data.");
                    continue;
                }

                var comment = new Comment()
                {
                    PostId = post.Id,
                    UserId = user.Id,
                    Content = content
                };
                validComments.Add(comment);
                sb.AppendLine($"Successfully imported Comment {comment.Content}.");
            }
            context.Comments.AddRange(validComments);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }
    }
}
