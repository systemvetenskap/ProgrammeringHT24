namespace FarmingGame
{
    /// <summary>
    /// basklass för alla typer av fåglar
    /// basklass = förälder
    /// </summary>
    public class Bird
    {
        protected readonly Random _random = new Random();
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHealty { get; }
        public int Energy { get; protected set; }
        public Egg MyEgg { get; protected set; } // det här betyder ett enda ägg
        public List<Feather> Feathers { get; set; } = new List<Feather>();

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

    }
}
