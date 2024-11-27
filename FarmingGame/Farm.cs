namespace FarmingGame
{
    public class Farm
    {
        private static readonly Random _random = new Random();

        /* i den här klassen lägger vi bondens alla djur
         * det är vår hönsgård
         * här skulle vi då kunna tänka oss att bonden matar sina djur
         */
        private List<string> _henNames = new List<string>
        {
            "Ada", "Beda", "Cilla", "Disa", "Elsa", "Fina", "Gullan", "Hulda",
            "Ida", "Julla", "Klara", "Lina", "Märta", "Nanna", "Olga", "Petra",
            "Rosa", "Saga", "Tora", "Ulla", "Vera", "Wilma", "Ylva", "Zelda",
            "Astrid", "Berta", "Cecilia", "Dagmar", "Edith", "Freda", "Gerda", "Hilda",
            "Inga", "Johanna", "Kerstin", "Lotta", "Magda", "Nina", "Otilia", "Pia",
            "Ronja", "Selma", "Tea", "Ursula", "Viola", "Wanda", "Yvette", "Zandra",
            "Alma", "Britta", "Clara", "Daga", "Emma", "Frida", "Greta", "Hanna",
            "Irma", "Julia", "Karin", "Linda", "Mona", "Nora", "Ottilia", "Polly"
        };
        public List<Hen> Hens { get; set; } = new List<Hen>();
        // List<Person> people
        public Farm(int numberOfHens)
        {
            // Nu vet vi hur många höns bonden vill skaffa -- numberOfHens
            int nameIndex = 0;
            for (int i = 0; i < numberOfHens; i++)
            {
                // generera dessa och låt dem flytta in i ett hönshus
                int magicNumber = _random.Next(_henNames.Count);
                int age = _random.Next(1, 4);

                string name = _henNames[magicNumber];
                name = _henNames[nameIndex];
                Hen newHen = new Hen(name, age);
                Hens.Add(newHen);
                if (nameIndex == _henNames.Count - 1)
                {
                    nameIndex = -1;
                }
                nameIndex++;
            }

        }
    }
}
