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
            int diceOne, diceTwo, diceThree, diceFour, diceFive;

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