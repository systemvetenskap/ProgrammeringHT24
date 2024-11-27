namespace FarmingGame
{
    public class Cow
    {
        // här beskriver vi vad vår ko ska kunna göra 
        // och hur kon "ser ut" --> dess egenskaper Property
        public double Weight { get; private set; }

        public void Eat()
        {
            // om den äter hö
            // kraftfoder
            // affärslogik
            Weight = 100;
        }
    }
}
