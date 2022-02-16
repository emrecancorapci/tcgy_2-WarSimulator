namespace tcgy_2_WarSimulator.Entities
{
    public class Weapon
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
