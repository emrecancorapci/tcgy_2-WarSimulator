using System.Collections.Generic;

namespace tcgy_2_WarSimulator.Entities
{
    internal class Army
    {
        private Queue<Soldier> soldiers = new Queue<Soldier>();

        public int Count => soldiers.Count;
        public string Name { get; private set; }

        public Army(string name, int size)
        {
            Name = name;

            for (var i = 0; i < size; i++)
            {
                var soldier = new ArmySoldier(name, i);
                soldiers.Enqueue(soldier);
            }
        }

        public Soldier GetSolider()
        {
            return soldiers.Dequeue();
        }

        public void AddSoldier(Soldier soldier)
        {
            soldiers.Enqueue(soldier);
        }
    }
}
