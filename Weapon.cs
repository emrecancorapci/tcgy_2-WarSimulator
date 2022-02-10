using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcgy_2_War_Simulator
{
    internal class Weapon
    {
        private int damage;
        private string name;

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public int GetDamage()
        {
            return damage;
        }

        public string GetName()
        {
            return name;
        }
    }
}
