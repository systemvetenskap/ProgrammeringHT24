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

namespace Kalkylatorn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _counter;
        public MainWindow() // konstruktor
        {
            InitializeComponent();
            _counter = 100;
        }

        private void OnButtonAdd(object sender, RoutedEventArgs e)
        {
            // hämta alla värden från gränssnittet så att jag kan beräkna
            // saker i C# kallas objekt
            // OO objektorienterad programmering
            // objekt har egenskaper
            // objekt har beteenden = metoder = har alltid parentes
            // ByeIceCream("Cornetto vanilj");


            double firstValue = double.Parse(txtFirstValue.Text);
            double secondValue = int.Parse(txtSecondValue.Text);
            double result = 0;
        

            // varför sätter jag denna till 0?
            result = 0;
          
            // gör beräkning
            result = firstValue + secondValue;  
            txtResult.Text=result.ToString(); // presenterar värdet som en sträng
            // glapp med massa kodrader
            MessageBox.Show(result.ToString());
            // txtResult.Text = (firstValue + secondValue).ToString();
            _counter++;
        }

        private void OnButtonDivision(object sender, RoutedEventArgs e)
        {
            double result =0.0;
            double firstValue = double.Parse(txtFirstValue.Text);
            double secondValue = double.Parse(txtSecondValue.Text);

            result = firstValue / secondValue;

            txtResult.Text = Math.Round(result, 2).ToString();


            //// mer om division
            //int divisor = 3;
            //result = firstValue / divisor;
            //// nu castar jag min variabel till en integer
            //int result2 = (int)firstValue / divisor;
            //txtResult.Text = result2.ToString(); // presenterar värdet som en sträng
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            
            _counter--; // counter = counter -1;
            txtResult.Text = _counter.ToString();

        }
    }
}