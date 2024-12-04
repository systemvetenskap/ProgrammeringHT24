namespace FarmingGame
{
    public class Hen : Bird
    {
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
        public void LayEgg()
        {
            Energy -= 6;
            Egg egg = new Egg();
            MyEgg = egg;
        }


    }
}
