using System;
using tcgy_2_WarSimulator.Simulator;

namespace tcgy_2_WarSimulator.Entities
{
    public class Soldier
    {
        public Random Random = new();
        public Weapon Weapon { get; protected set; }
        public int HitPoint { get; protected set; }
        public int Health { get; protected set; } = SimulatorSettings.Health;
        public string Name { get; protected set; }
        public bool IsAlive => Health > 0;

        protected const int HitPointUpLimit = 8;
        protected const int HitPointDownLimit = 1;

        private static int _id;
        private const int Armor = 2;

        public Soldier()
        {
            NameSoldier();
            CreateSoldier();
        }

        private void NameSoldier(string name = "Soldier")
        {
            Name = $"{++_id}. {name}";
        }

        protected void CreateSoldier()
        {
            HitPoint = Random.Next(HitPointDownLimit, HitPointUpLimit);
            Weapon = Weapons.GetRandomWeapon();
        }

        public int GiveDamage()
        {
            var damage = Random.Next(0, HitPoint);
            return damage + Weapon.GetDamage();
        }

        public int GetDamage(int damageAmount)
        {
            if (damageAmount < Armor) return SimulatorSettings.MinimumDamage;
            
            Health -= damageAmount;

            return damageAmount;
        }
    }

    internal class ArmySoldier : Soldier
    {
        private int _soldierId;

        public ArmySoldier(string sideName, int soldierId)
        {
            _soldierId = soldierId;
            NameArmySoldier(sideName);
            CreateSoldier();
        }

        private void NameArmySoldier(string sideName, string name = "Soldier")
        {
            Name = $"{sideName}'s {++_soldierId}. Soldier";
        }

    }
}
