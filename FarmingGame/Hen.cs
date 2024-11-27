namespace FarmingGame
{
    public class Hen
    {
        private readonly Random _random = new Random();
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool IsHealty { get; }
        public int Energy { get; private set; }
        public Hen(string name, int age)
        {
            Name = name;
            Age = age;

            // Hönan ska få startenergi
            Energy = _random.Next(3, 10) / age;
        }

        // hönorna ska kunna äta
        // skapa en metod för äta som ökar energin med säg 3 enheter

        // vila
        // skapa en annan metod för att vila som ger 2 energienheter


        // värpa ägg
        // Gör en metod som värper ägg
        // Hönan värper ett ägg per 2 energienheter
        // t ex 4 energi --> 2 ägg
        // 5 energi --> 2 ägg
        // 6 energi --> 3 ägg



    }
}
