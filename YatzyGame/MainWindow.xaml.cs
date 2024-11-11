using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YatzyGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _total = 0;
        // varför skriver jag new???
        // jo, det för att vi gör ett objekt
        // från en mall = klass

        // vi kallar detta även för instans
        private static readonly Random _random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonOk(object sender, RoutedEventArgs e)
        {

            // kategorier
            int categoryOnes = 0, categoryTwos = 0, categoryThrees = 0, categoryFours = 0, categoryFives = 0, categorySixes = 0;


            categoryOnes = int.Parse(txtOnes.Text);
            categoryTwos = int.Parse(txtTwos.Text);



            // Vi måste styra koden
            // antingen är talsumman rätt, eller så är talsumman fel
            // vi kontrollerar tvåor
            if (categoryTwos == 0 || categoryTwos == 2 || categoryTwos == 4 || categoryTwos == 6 || categoryTwos ==8 || categoryTwos == 10)
            {
                _total += categoryTwos;
            }
            int result = categoryTwos % 3;
            // modulus
            if (categoryTwos % 2 == 0 && categoryTwos <= 10)
            {
                // om detta villkor är sant har vi en talsumma som är jämnt delbart med 2
            }
            _total = categoryOnes + categoryTwos + categoryThrees + categoryFours + categoryFives + categorySixes;

                // får spelaren bonus??
            if (_total >= 63)  // allt inom parentesen måste kunna svara på formen ja eller nej
            {
                // det som ligger inom kodblocket körs BARA när villkoret valideras som sant
                _total += 50; //--> total = total + 50;
                txtBonus.Text = "50";
            }
            else
            {
                // det här kodblocket körs bara när villkoret INTE är uppfyllt
                txtBonus.Text = "X";
            }
            // presentera resultatet
            txtTotal.Text = _total.ToString();










            // Det här ska vi fixa längre fram i våra föreläsningar
            // få till en sätt att kasta våra tärningar och de dem värden

            // eftersom vi inte kan kasta tärningar behöver vi testdata
          

            // summer tärningarna
            // total 
            // och alla ettor

            // när vi har kastat tärningarna, vill vi att användare
            // ska kunna mata in värdet hen fick vid kastet i rätt ruta
        }

        private void btnRollDice_Click(object sender, RoutedEventArgs e)
        {
            int diceOne = 0, diceTwo = 0, diceThree = 0, diceFour = 0, diceFive = 0;

            // vi vill slumpa ett värde på min tärning

            // Vi behöver skaffa en slumpgenerator
            // vi skapar slumpgenerator som en instansvariabel
            // global variabel

            // vi vill slumpa fram ett rimligt värde för första tärningen
            // 1, 2, 3, 4, 5, 6
            diceOne = _random.Next(1, 7);
            diceTwo = _random.Next(1, 7);
            diceThree = _random.Next(1, 7);
            diceFour = _random.Next(1, 7);
            diceFive = _random.Next(1, 7);

            lblDiceOne.Content = diceOne.ToString();
            lblDiceTwo.Content = diceTwo.ToString();
            lblDiceThree.Content = diceThree.ToString();
            lblDiceFour.Content = diceFour.ToString();
            lblDiceFive.Content = diceFive.ToString();

            // måste jag verkligen hålla på med så många variabler? Jag blir tokig
            // av att du hela tiden måste klippa och klistra
            // jag vill ha en array
            // om du sätter en hakparentes efter datatypen så får du en array
            // arrayen är en låda med många variabler

            // vi skapar en array med fem fack. En för varje tärning
            int[] dices = new int[5];

            // vi måste stoppa in våra tärningsslag
            // men vi behöver hålla koll på i vilket fack respektive
            // tärninsslag ska sparas.

            // vi använder ett indexvärde
            // det börjar ALLTID på noll 

            // tärning nummer 1, har index 0
            //dices[0] = diceOne;

            //// tärning nummer 2, har index 1
            //dices[1] = diceTwo;

            //dices[2] = diceThree;
            //dices[3] = diceFour;
            //dices[4] = diceFive;


            // en array är som gjord för en snurra eller loop

            // LOOP är superbra för att köra kod i en sekvens 
            // en av alla loopar är for-loopen

            // Syntax för en for-loop
            // tre statements
            // uttryck1: startvärdet. Ofta är detta 0 eftersom det
            // lirar bra med ett index som börjar med noll

            //uttryck2: Ett villkor som valideras som sant eller falskt
            // som avgör frågan: Ska jag loopa ett varv till?
            // i < 5

            // statment 3: Hur mycket ka värdet av vår variabel (i)
            // öka varje varv i loopen?
            // det vanligaste här är en etta
            for(int i = 0; i < 5; i++)
            {
                dices[i] = _random.Next(1, 7);
            }

            lblDiceOne.Content = dices[0].ToString();
            lblDiceTwo.Content = dices[1].ToString();
            lblDiceThree.Content= dices[2].ToString();
            lblDiceFour.Content= dices[3].ToString();
            lblDiceFive.Content = dices[4].ToString();

            // hemläxa
            // använd en for-loop för att summera värdena från alla tärningar

        }
    }
}