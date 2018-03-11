using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Models.Weapons;
using InfernoInfinity.Models.Gems;
using InfernoInfinity.Factories;

namespace InfernoInfinity
{
    public class Repository
    {
        private readonly List<Weapon> weapons;
        private WeaponFactory weapFact;
        private GemFactory gemFact;
        public Repository()
        {
            weapons = new List<Weapon>();
            weapFact = new WeaponFactory();
            gemFact = new GemFactory();
        }
        public void Create(List<string> tokens)
        {
            weapons.Add(weapFact.Create(tokens));
        }
        public void Add(List<string> tokens)
        {
            string weaponName = tokens[0];
            int socketIndex = int.Parse(tokens[1]);
            string gemType = tokens[2];
            Weapon currWeapon = weapons.First(x => x.Name == weaponName);
            currWeapon.AddGem(socketIndex, gemFact.Create(gemType));
        }
        public void Remove(List<string> tokens)
        {
            string weaponName = tokens[0];
            int socketIndex = int.Parse(tokens[1]);
            Weapon currWeapon = weapons.First(x => x.Name == weaponName);
            currWeapon.RemoveGem(socketIndex);
        }
        public string Print(List<string> tokens)
        {
            string weaponName = tokens[0];
            Weapon currWeapon = weapons.First(x => x.Name == weaponName);
            return currWeapon.ToString();
        }
    }
}
