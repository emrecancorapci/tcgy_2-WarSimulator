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
            AddSoldierToList(size);
        }

        public Soldier GetSolider()
        {
            return _soldiers.Dequeue();
        }

        public void AddSoldier(Soldier soldier)
        {
            _soldiers.Enqueue(soldier);
        }

        private void AddSoldierToList(int size)
        {
            for (var i = 0; i < size; i++)
            {
                var soldier = new ArmySoldier(Name, i);
                _soldiers.Enqueue(soldier);
            }
        }
    }
}
