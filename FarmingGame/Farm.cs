namespace FarmingGame
{
    public class Farm
    {
        private static readonly Random _random = new Random();

        /* i den här klassen lägger vi bondens alla djur
         * det är vår hönsgård
         * här skulle vi då kunna tänka oss att bonden matar sina djur
         */
        private List<Bird> _birds = new List<Bird>();
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
        public List<Chicken> Chickens { get; set; } = new List<Chicken>();
        public List<Turkey> Turkeys { get; set; } = new List<Turkey>();
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

        public string FarmerTranslates(string message)
        {
            /* Jag  vill testa om strängen går att läsa baklänges
             * det kan vi göra genom att låta en for-loop snurra baklänges
             * kire
             * [e][r]ik
             * A bcdefg
             */
            int steps = 3;
            string encrypted = StringHelper.Reverse(message);
            string humanMessage = string.Empty;
            foreach (char letter in encrypted)
            {
                humanMessage += (char)(letter - 3);
            }
            return humanMessage;
        }

        public void AddNewBird(Bird bird)
        {
            // lägg den i en lista
            _birds.Add(bird);
        }

        public List<Hen> SimulateDay()
        {
            // hämta alla döda höns
            // alla hönor vars energi är under noll
            List<Hen> deadHens = new List<Hen>();
            foreach (Hen hen in Hens)
            {
                // om energin under dagen blir <0 så dör hönan

                hen.Eat();
                hen.LayEgg();
                if (hen.Energy < 0)
                {
                    deadHens.Add(hen);
                    continue;
                }
                hen.Eat();
                hen.Sleep();
            }
            /* här vill jag plocka bort de döda hönsen
             * men eftersom vi är inuti vår loop med hönor
             * kommer det kunna bli konstiga index
             * skapar därför en egen metod
             */
            RemoveDeadHens(deadHens);
            return deadHens;
        }
        private void RemoveDeadHens(List<Hen> deadHens)
        {
            // här loopar vi inte vår Hens property
            // utan vi kikar på våra döda hönor. Den listan
            // blir då intakt
            foreach (Hen deadHen in deadHens)
            {
                Hens.Remove(deadHen);
            }
        }
    }
}
