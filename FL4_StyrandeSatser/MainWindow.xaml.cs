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

namespace FL4_StyrandeSatser
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
            // poliskontroll
            // kontrollera nykterhet 
            // kontrollera hastighet
            // bool true false
            bool isSober = false;
            bool hasCorrectSpeed = false;
            // "Erik" == "Erik"
            // false == false
            int total = 3, speed=135, currentSpeedLimit = 90;

            if (total != 63)
            {

            }

            if (total < 63 || total > 63)
            {

            }

            if (total > 63)
            {
                // bonus
            }
            else if( total == 63)
            {
                // dubbel bonus
            }
            else
            {
                // ingen bonus
            }

            // om vi sätter ett ! framför uttrycket vänder det håll
            if (!isSober) // isSober == false
            {
                // polisen låter mig inte köra vidare!
            }
            bool loseLicence = speed - currentSpeedLimit > 30;
            if (!hasCorrectSpeed)
            {
                // du får böter men får jag köra vidare?
                if (loseLicence)
                {
                    return;
                }
            }
            // !false
            // its funny because its true
            if (isSober && hasCorrectSpeed )
            {
                    // polisen ger beröm för bra kört!
            }
            else
            {
              
                // fy fy fy
            }


        }
    }
}