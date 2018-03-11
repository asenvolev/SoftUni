using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Entities;
namespace MilitaryElite
{
    public class StartUp
    {
        private static IList<ISoldier> army;
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            army = new List<ISoldier>();
            while (input !="End")
            {
                var tokens = input.Split(' ').ToArray();
                switch (tokens[0])
                {
                    default:
                        break;
                    case "Private":
                        army.Add(new Private(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4])));
                        break;
                    case "LeutenantGeneral":
                        var privates = CreatePrivatesList(tokens.Skip(5).ToList());
                        army.Add(new LeutenantGeneral(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4]), privates));
                        break;
                    case "Engineer":
                        string corp = tokens[5];
                        if (corp != "Airforces" && corp != "Marines")
                        {
                            break;
                        }
                        var repairs = CreateRepairsList(tokens.Skip(6).ToList());
                        army.Add(new Engineer(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4]), corp, repairs));
                        break;
                    case "Commando":
                        string corps = tokens[5];
                        if (corps != "Airforces" && corps != "Marines")
                        {
                            break;
                        }
                        var missions = CreateMissionsList(tokens.Skip(6).ToList());
                        army.Add(new Commando(int.Parse(tokens[1]), tokens[2], tokens[3], double.Parse(tokens[4]), corps, missions));
                        break;
                    case "Spy":
                        army.Add(new Spy(int.Parse(tokens[1]), tokens[2], tokens[3], int.Parse(tokens[4])));
                        break;
                }
                input = Console.ReadLine();
            }
            foreach (var soldier in army)
            {
                Console.WriteLine(soldier);
            }
        }

        private static IList<Mission> CreateMissionsList(IList<string> missons)
        {
            var list = new List<Mission>();
            for (int i = 0; i < missons.Count - 1; i += 2)
            {
                if (missons[i+1] == "inProgress" || missons[i + 1] == "Finished")
                {
                    list.Add(new Mission(missons[i], missons[i + 1]));
                }
            }
            return list;
        }

        private static IList<Repair> CreateRepairsList(IList<string> repairs)
        {
            var list = new List<Repair>();
            for (int i = 0; i < repairs.Count-1; i+=2)
            {
                list.Add(new Repair(repairs[i], int.Parse(repairs[i + 1])));
            }
            return list;
        }

        private static IList<ISoldier> CreatePrivatesList(IList<string> soldiers)
        {
            var list = new List<ISoldier>();
            foreach (var soldier in soldiers)
            {
                list.Add(army.First(x => x.Id == int.Parse(soldier)));
            }
            return list;
        }
    }
}
