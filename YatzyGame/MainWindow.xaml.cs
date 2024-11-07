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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonOk(object sender, RoutedEventArgs e)
        {
            int diceOne = 0, diceTwo = 0, diceThree = 0, diceFour = 0, diceFive = 0, total = 0;

            // kategorier
            int categoryOnes = 0, categoryTwos = 0, categoryThrees = 0, categoryFours = 0, categoryFives = 0, categorySixes = 0;


            categoryOnes = int.Parse(txtOnes.Text);


            total = categoryOnes + categoryTwos + categoryThrees + categoryFours + categoryFives + categorySixes;

            // får spelaren bonus??
            if (total >= 63) // allt inom parentesen måste kunna svara på formen ja eller nej
            {
                // det som ligger inom kodblocket körs BARA när villkoret valideras som sant
                total += 50; //--> total = total + 50;
                txtBonus.Text = "50";
            }
            else
            {
                // det här kodblocket körs bara när villkoret INTE är uppfyllt
                txtBonus.Text = "X";
            }
            // presentera resultatet
            txtTotal.Text = total.ToString();










            // Det här ska vi fixa längre fram i våra föreläsningar
            // få till en sätt att kasta våra tärningar och de dem värden

            // eftersom vi inte kan kasta tärningar behöver vi testdata
            diceOne = 2;
            diceTwo = 1;
            diceThree = 2;
            diceFour = 3;
            diceFive = 4;

            // summer tärningarna
            // total 
            // och alla ettor

            // när vi har kastat tärningarna, vill vi att användare
            // ska kunna mata in värdet hen fick vid kastet i rätt ruta
        }

       
    }
}