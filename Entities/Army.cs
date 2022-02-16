using System.Collections.Generic;

namespace tcgy_2_WarSimulator.Entities
{
    internal class Army
    {
        private readonly Queue<Soldier> _soldiers = new();

        public int Count => _soldiers.Count;
        public string Name { get; }

        public Army(int size, string name)
        {
            Name = name;

            for (var i = 0; i < size; i++)
            {
                var soldier = new ArmySoldier(name, i);
                _soldiers.Enqueue(soldier);
            }
        }

        public Soldier GetSolider()
        {
            return _soldiers.Dequeue();
        }

        public void AddSoldier(Soldier soldier)
        {
            _soldiers.Enqueue(soldier);
        }
    }
}
