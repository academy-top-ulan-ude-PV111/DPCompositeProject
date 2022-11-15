namespace DPCompositeProject
{
    internal class Program
    {
        static Unit CreateUnit(int number)
        {
            switch(number)
            {
                case 0: return new Infantry();
                case 1: return new Archer();
                case 2: return new Cavalery();
                default:
                    return null;
            }
        }
        static void Main(string[] args)
        {
            Random random = new();

            Team army = new Team();

            Team team1 = new Team();

            for (int i = 0; i < 10; i++)
                team1.Units.Add(CreateUnit(random.Next(0, 2)));

            for (int i = 0; i < 10; i++)
                army.Units.Add(CreateUnit(random.Next(0, 2)));

            army.Units.Add(team1);

            army.Info();
        }
    }
}