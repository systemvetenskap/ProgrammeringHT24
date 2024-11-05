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

namespace FL2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() // en låda som handlar om själva fönstret
        {
            // en enkel kommentar
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // vi skapar en variabel
            // datatyp namn + eventuellt startvärde
            int currentYear = 2024, yearOfBirth, age;

            // namnconvention.
            // för en variabel. Börja alltid med en liten bokstav, fyll sedan varje ord
            // med en stor = camelCase
            // vi behöver konvertera strängen som jag har matat in i textrutan
            // till att bli ett heltal

            // för detta använder jag här metoden int.Parse()

            // den metoden behöver en så kalla indataparameter = textrutan
            yearOfBirth = int.Parse(txtAge.Text); 


            age = currentYear - yearOfBirth;

            // Vi vill skriva ut åldern på skärmen
            // eftersom vi inte kan säga att en sträng är ett heltal
            // så måste vi konvertera till rätt datatayp

            // detta görs med metoden ToString()
            // en metod måste alltid ha parenteser
            //int convertedValue = Convert.ToInt32("12");
            txtAge.Text = age.ToString();

            // Formattera texten så att det blir ålern+ texten år

            // sträng interpolation
            // typ = fixa till min sträng så att den blir snygg

            txtAge.Text = $"{age} år";

            txtAge.Text = "Du är " + age + " år gammal";

        }
    }
}