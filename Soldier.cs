﻿using System;

namespace tcgy_2_War_Simulator
{
    internal class Soldier
    {
        public static int Id;
        public Random Random = new();

        public Weapon Weapon { get; }
        public ConsoleColor Color { get; set; }
        public int HitPoint { get; }
        public int Health { get; private set; } = 100;
        public int Armor { get; } = 2;
        public string Name { get; set; }
        public bool IsAlive { get; private set; } = true;

        private const int HitPointUpLimit = 8;
        private const int HitPointDownLimit = 1;


        public Soldier(string sideName = "", bool info = false)
        {
            NameSoldier(sideName);

            HitPoint = Random.Next(HitPointDownLimit, HitPointUpLimit);
            Weapon = new Weapon(Random.Next(0,4));

            if (info) SimulationConsole.SoldierInfo(this);
        }

        public void Attack(Soldier enemy)
        {
            SimulationConsole.AttackInfo(this, enemy);

            var damage = Random.Next(HitPoint);
            var amount = enemy.GetDamage(damage + Weapon.Damage);

            SimulationConsole.AttackOutput(enemy, amount);

            if (enemy.Health >= 0) return;
            SimulationConsole.DeadSoldierInfo(enemy);
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
    }
}
