namespace FL9_animal
{
    /* En klass är en mall.
     * Från mallen kan vi sedan skapa hur många
     * objekt som helst.
     */
    public class Hen
    {
        private readonly Random _random = new Random();
        public string Name { get; set; } // get --> hämta värde som finns
                                         // set --> Ge variabeln (property) ett värde

        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsHealty { get; }
        public bool IsHungry { get; set; }
        public Hen()
        {
            /* Vad ska hända
             * när hönan skapas vill vi se om 
             * den är frisk eller sjuk
             * sjuk == 0
             * frisk == 1
             * 
             * vi slumpar ett tal  0 eller 1
             * 
             * med utgångspunkt av slumpen sätter vi värdet på
             * IsHealty till true eller false
             */

            int result = _random.Next(0, 2);
            if (result == 1)
            {
                IsHealty = true;
            }
            else
            {
                IsHealty = false;
            }
        }

    }
}
