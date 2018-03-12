namespace TeamBuilder.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public User()
        {
            this.ReceivedInvitations = new HashSet<Invitation>();
            this.UserTeams = new HashSet<UserTeam>();
            this.CreatedTeams = new HashSet<Team>();
            this.CreatedEvents = new HashSet<Event>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(25,MinimumLength =3)]
        public string Username { get; set; }

        [MaxLength(25)]
        public string FirstName { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        [StringLength(30,MinimumLength=6)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).+$")]
        public string Password { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Invitation> ReceivedInvitations { get; set; }

        public ICollection<UserTeam> UserTeams { get; set; }

        public ICollection<Team> CreatedTeams { get; set; }

        public ICollection<Event> CreatedEvents { get; set; }
    }
}
