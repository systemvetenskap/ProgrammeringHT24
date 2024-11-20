using System.Windows;

namespace FL8_metod
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


        private char GetFirstLetterFromText(string text)
        {
            return text[0];
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // jag vill veta första bokstaven i mitt namn

            // Erik

            // --> E

            // metoder. Det är ju såååå svårt
            string name = "Erik";

            // en sträng är en sekvens av många bokstäver
            // i c# heter bokstav char, tecken

            // JO LOOP

            foreach (char letter in name)
            {

            }

            // i en array kan vi ju hämta ett specifikt fack 
            // det gör vi med index [index]

            // alla arrayer börjar ALLTID på 0
            char firstLetterInName = name[0];

            // vi vill nu flytta koden till en metod

            // den vill veta vilket namn som ska analyseras
            // svaret ska bli första bokstaven
            name = "Lovisa Jönsson";
            firstLetterInName = GetFirstLetterFromText(name);

            // men vad blir då sista bokstaven?
            // jo det blir din hemläxa
            // GetLastLetterFromText
            // en metod ytterligare.

            // hur många bokstäver är det i strängen som skickas?
            // CountLettersInText
            // den ska då svara med en siffra med antalet bokstäver

            // DisplayFruits(string[] fruits)
            // jo, den fixar och trixar med frukterna så att de skrivs ut rätt
            // banan
            // banan och kiwi
            // banan, kiwi och melon
        }






    }
}