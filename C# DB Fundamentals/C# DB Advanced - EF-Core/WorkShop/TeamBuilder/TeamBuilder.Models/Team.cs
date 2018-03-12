namespace TeamBuilder.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Team
    {
        public Team()
        {
            this.UserTeams = new HashSet<UserTeam>();
            this.Invitations = new HashSet<Invitation>();
            this.Events = new HashSet<TeamEvent>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [MaxLength(32)]
        public string Description { get; set; }

        [Required]
        [StringLength(3,MinimumLength =3)]
        public string Acronym { get; set; }

        public int CreatorId { get; set; }
        public User Creator { get; set; }

        public ICollection<Invitation> Invitations { get; set; }

        public ICollection<UserTeam> UserTeams { get; set; }

        public ICollection<TeamEvent> Events { get; set; }
    }
}
