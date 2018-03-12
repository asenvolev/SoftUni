namespace Instagraph.Data
{
    using Instagraph.Data.Configurations;
    using Instagraph.Models;
    using Microsoft.EntityFrameworkCore;

    public class InstagraphContext : DbContext
    {
        public InstagraphContext() { }

        public InstagraphContext(DbContextOptions options)
            :base(options) { }
        
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserFollower> UsersFollowers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Picture>(new PictureConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            modelBuilder.ApplyConfiguration<Post>(new PostConfiguration());
            modelBuilder.ApplyConfiguration<Comment>(new CommentConfiguration());
            modelBuilder.ApplyConfiguration<UserFollower>(new UserFollowerConfiguration());
        }
    }
}
