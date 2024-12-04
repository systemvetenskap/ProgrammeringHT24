using System.Windows;

namespace FarmingGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /* Cow cow = new Cow();
            double weight = cow.Weight;
            cow.Eat();
            weight = cow.Weight;
        */
        Farm _farm;
        public MainWindow()
        {
            InitializeComponent();
            _farm = new Farm(1000);
        }

        private void OnButtonOkClick(object sender, RoutedEventArgs e)
        {
            Chicken chicken = new Chicken()
            {
                Age = 12,
                Name = "kackla",
            };
            chicken.Clucks("asdfaslkdf");
            chicken.Eat();
            _farm.AddNewBird(chicken);
            List<Hen> hens = new List<Hen>();
            Hen hen = new Hen("Stor-Johan", 3);

            _farm.AddNewBird(hen);
            hens.Add(hen);
            List<Hen> deadHens = _farm.SimulateDay();



            // Regel
            // alla hönor i vårt spel måste ha ett namn och en ålder när de skapas
            //Hen hen = new Hen("Agda", 2);
            //string message = hen.Clucks("hej");
            //string humanMessage = _farm.FarmerTranslates(message);

            //hen.LayEgg();

        }
    }
}