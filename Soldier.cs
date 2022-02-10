using System;

namespace tcgy_2_WarSimulator
{
    internal class Soldier
    {
        public static int Id;
        public Random Random = new();

        public Weapon Weapon { get; private set; }
        public int HitPoint { get; private set; }
        public int Health { get; private set; } = SimulatorSettings.Health;
        public int Armor { get; } = 2;
        public string Name { get; private set; }
        public bool IsAlive { get; private set; } = true;

        private const int HitPointUpLimit = 8;
        private const int HitPointDownLimit = 1;


        public Soldier(string sideName)
        {
            NameSoldier(sideName);

            CreateSoldier();
        }

        public Soldier()
        {
            NameSoldier();

            CreateSoldier();
        }

        private void CreateSoldier()
        {
            HitPoint = Random.Next(HitPointDownLimit, HitPointUpLimit);
            Weapon = Weapons.GetRandomWeapon();
        }

        public int Attack(Soldier enemy)
        {
            var damage = SimulatorSettings.MinimumDamage + Random.Next(0, HitPoint);
            var amount = enemy.GetDamage(damage + Weapon.GetDamage());

            if (enemy.Health < 0) enemy.IsAlive = false;

            return amount;
        }

        public int GetDamage(int damageAmount)
        {
            if (damageAmount < Armor) return 0;
            
            Health -= damageAmount;

            if (Health < 0) IsAlive = false;

            return damageAmount;
        }

        private void NameSoldier(string sideName)
        {
            Name = $"{sideName} - {++Id}. Soldier";
        }

        private void NameSoldier()
        {
            Name = $"{++Id}. Soldier";
        }
    }
}
