namespace FarmingGame
{
    public class Hen
    {
        private readonly Random _random = new Random();
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool IsHealty { get; }
        public int Energy { get; private set; }
        public Egg MyEgg { get; private set; } // det här betyder ett enda ägg
        public List<Feather> Feathers { get; set; } = new List<Feather>();

        private void InitializeFeathers()
        {
            Feather feather;
            for (int i = 0; i < 500; i++)
            {
                feather = new Feather();
                Feathers.Add(feather);
            }
        }


        public Hen(string name, int age)
        {
            Name = name;
            Age = age;

            // Hönan ska få startenergi
            Energy = _random.Next(3, 10) / age;
            InitializeFeathers();
        }
        public void Eat()
        {
            Energy += 3;
        }

        public void Sleep()
        {
            Energy += 2;
        }
        // vad är det hönan eller tuppen säger?
        public string Clucks(string message)
        {
            // vänd på strängen
            // lägg på tre tecken
            // returnera
            string encrypted = StringHelper.Reverse(message);

            string jibberish = "qhnfroi#l#dqlnv#jlg#hv#hwql#wwd#wjlomùpr";
            return jibberish;
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

        public void LayEgg()
        {
            Energy -= 6;
            Egg egg = new Egg();
            MyEgg = egg;
        }


    }
}
