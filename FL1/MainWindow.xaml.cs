using System.Windows;

namespace FL1
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            // Här kommer koden för knappen att köras
            //MessageBox.Show("Hej Erik");

            // hur kan vi byta ut Erik?

            // datatyper

            // låt oss skapa en variabel

            // en variabel är en låda som kan innehålla och spara värden

            // vi skapar en variabel med namnet!
            // mönster för variabler
            // först: datatyp
            // därefter: namnet på variabeln
            // eventuellt: startvärdet för variabeln

            // https://www.w3schools.com/cs/cs_data_types.php
            string name;

            // vi ska tilldela värde till vår variabel
            // det gör vi med ett enkelt =

            // detta gör vi från höger till vänster
            name = "Erik";
            name = "Yasmine";
            //MessageBox.Show(name);

            // Vi kan inte enbart tilldela värden till variabler
            // de kan också användas för attribut på kontroller
            // alla attribut når vi med punkt-notation
            btnOk.Content = name;
        }
    }
}