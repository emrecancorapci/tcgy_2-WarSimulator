using System;
using System.Collections.Generic;

namespace tcgy_2_WarSimulator
{
    internal static class Weapons
    {
        public static Random Random = new();


        public static List<Weapon> WeaponsList { get; } = new();

        static Weapons()
        {
            string[] weaponNames = { "Fist", "Blade", "Rifle", "Tank"};

            for (var i = 0; i < weaponNames.Length; i++)
            {
                AddWeapon(weaponNames[i], i);
            }
        }

        public static Weapon GetRandomWeapon()
        {
            var n = Random.Next(WeaponsList.Count);
            return WeaponsList[n];
        }

        public static void AddWeapon(string name, int damage)
        {
            var weapon = new Weapon(name, damage);
            WeaponsList.Add(weapon);
        }

    }
}
