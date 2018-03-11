using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfernoInfinity.Models.Gems;

namespace InfernoInfinity.Models.Weapons
{
    public abstract class Weapon
    {
        private readonly List<Gem> gems;
        public Weapon(Rarity rarity, string name, int minDamage, int maxDamage, int numOfSockets)
        {
            this.Rarity = rarity;
            this.Name = name;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.NumOfSockets = numOfSockets;
            this.gems = new List<Gem>(new Gem[this.NumOfSockets]);
            this.SetRarity();
        }
        public Rarity Rarity;
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int NumOfSockets { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
        public void SetRarity()
        {
            this.MinDamage *= (int)Rarity;
            this.MaxDamage *= (int)Rarity;
        }
        public void AddGem(int index, Gem gem)
        {
            if (index<this.NumOfSockets)
            {
                this.gems[index] = gem;
            }
        }
        public void RemoveGem(int index)
        {
            this.gems[index] = null;
        }
        public void CalculateStats()
        {
            foreach (var gem in this.gems)
            {
                if (gem!=null)
                {
                    this.Strength += gem.Strength;
                    this.Agility += gem.Agility;
                    this.Vitality += gem.Vitality;
                    this.MinDamage += gem.Strength * 2 + gem.Agility;
                    this.MaxDamage += gem.Strength * 3 + gem.Agility * 4;
                }
            }
        }
        public override string ToString()
        {
            this.CalculateStats();
            return $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, +{this.Strength} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";
        }
    }
}
