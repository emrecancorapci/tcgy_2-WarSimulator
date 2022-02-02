using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgy_2_War_Simulator
{
    internal class Weapon
    {
        public int Damage { get; set; }
        public string Name { get; set; }

        public Weapon(int damageAmount)
        {
            Damage = damageAmount;

            Name = damageAmount switch
            {
                0 => "Fist",
                1 => "Blade",
                2 => "Rifle",
                3 => "Tank",
                _ => "Unknown Weapon"
            };
        }
    }
}
