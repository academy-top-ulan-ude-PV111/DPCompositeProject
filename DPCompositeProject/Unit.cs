using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCompositeProject
{
    abstract class Unit
    {
        public abstract void Info();
        public abstract int Attack();
    }

    class Infantry : Unit
    {
        public override void Info()
        {
            Console.WriteLine("Infantry");
        }

        public override int Attack()
        {
            return 1;
        }
    }

    class Cavalery : Unit
    {
        public override void Info()
        {
            Console.WriteLine("Cavalery");
        }

        public override int Attack()
        {
            return 3;
        }
    }

    class Archer : Unit
    {
        public override void Info()
        {
            Console.WriteLine("Archer");
        }

        public override int Attack()
        {
            return 2;
        }
    }

    class Team : Unit
    {
        public List<Unit> Units { set; get; } = new List<Unit>();
        public override int Attack()
        {
            int attackFull = 0;
            foreach (Unit unit in Units)
                attackFull += unit.Attack();
            return attackFull;
        }

        public override void Info()
        {
            Console.WriteLine("\tTeam units");
            foreach(Unit unit in Units)
            {
                Console.Write("\t");
                unit.Info();
            }
               
        }
    }
}
