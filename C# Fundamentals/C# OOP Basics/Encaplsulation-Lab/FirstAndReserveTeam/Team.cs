using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;
    public Team(string name)
    {
        this.name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }
    public IReadOnlyCollection<Person> FirstTeam => this.firstTeam.AsReadOnly();
    public IReadOnlyCollection<Person> ReserveTeam => this.reserveTeam.AsReadOnly();
    public void AddPlayer(Person player)
    {
        if (player.Age<40)
        {
            this.firstTeam.Add(player);
        }
        else
        {
            this.reserveTeam.Add(player);
        }
    }
    public override string ToString()
    {
        return $"First team have {this.firstTeam.Count} players\nReserve team have {this.reserveTeam.Count} players";
    }
}

