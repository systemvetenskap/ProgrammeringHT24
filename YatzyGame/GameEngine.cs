namespace YatzyGame
{
    /// <summary>
    /// Våra spelregler som ligger i en separat klass.
    /// </summary>
    public static class GameEngine
    {
        private static int[] _dices = new int[5];
        private static readonly Random _random = new Random();
        // vi ska skapa en metod
        // att göra metoder påminner till viss del om variabler

        // skapa en eller möjligen flera metoder som räknar poäng för en kategori
        // ettor, tvåor, treor 
        // sedan vill vi i gränssnittet
        // 1. visa poängen i rätt kategori
        // 2. Uppdatera totalpoängen
        // 3. Undersöka om vi får bonus >= 63 poäng
        // 4. Om ja, visa bonus och öka maxpoängen

        // Fundera. VAR lägger jag dessa metoder bäst?
        // hur gör jag metoderna

        /// <summary>
        /// Kastar fem tärningar och får slumpmässiga värden mellan 1 och 6
        /// </summary>
        /// <returns></returns>
        /// 
        public static int[] RollDices(bool[] savedDices)
        {
            for (int i = 0; i < _dices.Length; i++)
            {
                // kolla om den är sparad
                _dices[i] = _random.Next(1, 7);
            }
            return _dices;
        }
        public static bool[] GetMaxValues()
        {
            // 2 ,4, 6 ,6 ,1
            bool[] hasHighestValues = new bool[_dices.Length];
            // false, false, false, true
            // om vi vet vilken  tärning som är högst
            // leta efter alla sådana tärningar

            int max = GetMaxValue();
            // loopa och leta

            for (int i = 0; i < _dices.Length; i++)
            {
                int dice = _dices[i];
                if (dice == max)
                {
                    hasHighestValues[i] = true;
                }
            }
            return hasHighestValues;
        }
        public static int GetMaxValue()
        {
            // loopa igenom alla tärningar

            // undersök värdet och se om det är högst
            // när loopen är klar vet vi högsta värdet. Returnera detta

            // när vi vill loopa igenom alla värden i en lista/array/kollektion/sekvens
            // 2 ,4, 6 ,6 ,1
            int maxValue = _dices[0];
            foreach (int dice in _dices)
            {
                if (dice == 6)
                {
                    return 6;
                }
                if (dice > maxValue)
                {
                    maxValue = dice;
                }
            }




            return maxValue;
        }
    }
}
