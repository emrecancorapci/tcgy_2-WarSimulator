using System;
using tcgy_2_WarSimulator.Simulator;

namespace tcgy_2_WarSimulator.Entities
{
    public class Soldier
    {
        private static int _id;
        public Random Random = new();

        public Weapon Weapon { get; protected set; }
        public int HitPoint { get; protected set; }
        public int Health { get; protected set; } = SimulatorSettings.Health;
        public int Armor { get; } = 2;
        public string Name { get; protected set; }
        public bool IsAlive => Health > 0;

        protected const int HitPointUpLimit = 8;
        protected const int HitPointDownLimit = 1;

        public Soldier()
        {
            NameSoldier();
            CreateSoldier();
        }

        protected void CreateSoldier()
        {
            HitPoint = Random.Next(HitPointDownLimit, HitPointUpLimit);
            Weapon = Weapons.GetRandomWeapon();
        }

        public int GiveDamage()
        {
            var damage = SimulatorSettings.MinimumDamage + Random.Next(0, HitPoint);

            return damage + Weapon.GetDamage();
        }

        public int GetDamage(int damageAmount)
        {
            if (damageAmount < Armor) return 0;
            
            Health -= damageAmount;

            return damageAmount;
        }

        private void NameSoldier()
        {
            Name = $"{++_id}. Soldier";
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

        private void NameArmySoldier(string sideName)
        {
            Name = $"{sideName}'s {++_soldierId}. Soldier";
        }

    }
}
