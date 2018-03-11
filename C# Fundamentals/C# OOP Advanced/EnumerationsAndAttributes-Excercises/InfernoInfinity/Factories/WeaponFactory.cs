using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Models.Weapons;

namespace InfernoInfinity.Factories
{
    public class WeaponFactory
    {
        public Weapon Create(List<string> tokens)
        {
            var elements = tokens[0].Split();
            Rarity rarity = (Rarity)(Enum.Parse(typeof(Rarity), elements[0]));
            string weaponType = elements[1];
            string weaponName = tokens[1];
            switch (weaponType)
            {
                default:
                    return null;
                case "Axe":
                    Weapon axe = new Axe(rarity, weaponName);
                    return axe;
                case "Sword":
                    Weapon sword = new Sword(rarity, weaponName);
                    return sword;
                case "Knife":
                    Weapon knife = new Knife(rarity, weaponName);
                    return knife;
            }
        }
    }
}
