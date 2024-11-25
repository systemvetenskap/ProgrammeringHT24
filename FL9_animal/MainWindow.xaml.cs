using System.Windows;

namespace FL9_animal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string name = "Agda";
            string name2 = "Smackis";

            name = name2;
            name2 = "Doris";



            int age = 3;
            int eggs = 1;   // 0 -- 2 ägg per dag
            bool isHealthy = true;
            bool isHungry = false;
            /* om vi har en "sak" i vår kod 
             * som vi vill beskriva med en rad olika
             * egenskaper och kanske metoder. 
             * Om de hänger samman. Då kan vi göra ett objekt
             */

            // vi skapar oss en höna
            // hönan är vårt objekt
            // som blir en kopia från vår mall
            Hen hen = new Hen();
            Random random = new Random();
            int[] numbers = new int[10];
            // vi vill döpa hönan
            hen.Name = "Agda";

            Hen hen2 = new Hen();
            hen2.Name = "Smackis";

            hen.Age = 3;
            hen2.Age = 1;

            hen = hen2;
            hen2.Name = "Doris";

            // var ska vi ha alla våra höns?
            // vi bygger en hönsgård
            // det är en kollektion av hönor
            Hen[] hens = new Hen[10];
            hens[0] = hen;
            hens[1] = hen2;

            // det finns dock en mycket roligare kollektion
            // Den heter LIST
            // en lista är som en array som kan växa under tiden
            // som den får nya objekt/tal/värden
            List<Hen> listOfHens = new List<Hen>();

            // vi vill ha en stoooor hönsgård
            // 15
            age = 0;

            Hen hen3 = new Hen();
            for (int i = 0; i < 1000; i++)
            {
                // Ni måste nya upp hönorna i loopen
                hen3 = new Hen();
                age++;
                hen3.Age = age;
                listOfHens.Add(hen3);
            }

            /* hemläxa
             * skulle du kunna hjälpa mig att hitta alla stackare
             * till hönor som INTE är friska
             * isHealty == false
             * Lägg de i en lista av sjuka hönor så att vi kan ge dem
             * god och hälsosam vård.
             * 
             * pseudokod
             * 
             * då måste  vi alltså loopa igenom listan av hönor
             * undersök varje höna om hon är frisk eller inte
             * är hon sjuk? Lägg henne i en egen lista
             */

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Hen hen = new Hen();
            // vi kan ge vår höna egenskaper
            // med punktnotation
            hen.Age = 12;
            hen.Name = "Agda";

            Hen hen2 = new Hen()
            {
                Age = 1, // tilldelar värden ---> SET
                Name = "hej",
                IsHungry = false
            };

            if (hen2.IsHungry) // GET
            {
            }

            // ett annat mycket vanligt sätt att skapa objekt
            // är att använda en konstruktor
        }
    }
}