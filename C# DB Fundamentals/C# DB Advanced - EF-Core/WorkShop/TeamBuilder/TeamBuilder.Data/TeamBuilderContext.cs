namespace TeamBuilder.Data
{
    using Microsoft.EntityFrameworkCore;
    using TeamBuilder.Models;
    using TeamBuilder.Data.Configurations;

    public class TeamBuilderContext : DbContext
    {
        public TeamBuilderContext()
        {
        }

        public TeamBuilderContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }
        public DbSet<TeamEvent> TeamEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            modelBuilder.ApplyConfiguration<Team>(new TeamConfiguration());
            modelBuilder.ApplyConfiguration<Event>(new EventConfiguration());
            modelBuilder.ApplyConfiguration<Invitation>(new InvitationConfiguration());
            modelBuilder.ApplyConfiguration<UserTeam>(new UserTeamConfiguration());
            modelBuilder.ApplyConfiguration<TeamEvent>(new TeamEventConfiguration());
        }
    }
}
