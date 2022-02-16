namespace tcgy_2_WarSimulator.Entities
{
    public class Weapon
    {
        private readonly int _damage;
        private readonly string _name;

        public Weapon(string name, int damage)
        {
            _name = name;
            _damage = damage;
        }

        public int GetDamage()
        {
            return _damage;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
