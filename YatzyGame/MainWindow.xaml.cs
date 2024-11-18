using System.Windows;

namespace YatzyGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _total = 0;
        // vi skapar en array med fem fack. En för varje tärning
        private int[] _dices = new int[5];


        // vi kallar detta även för instans
        private static readonly Random _random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonOk(object sender, RoutedEventArgs e)
        {

            bool[] savedDices = GetSavedDices();

            GameEngine.RollDices(savedDices);
            int max = GameEngine.GetMaxValue();
            bool[] highest = GameEngine.GetMaxValues();
            // använd gränsnittet med kryssrutorna för att markera högsta

            // kategorier
            int categoryOnes = 0, categoryTwos = 0, categoryThrees = 0, categoryFours = 0, categoryFives = 0, categorySixes = 0;


            categoryOnes = int.Parse(txtOnes.Text);
            categoryTwos = int.Parse(txtTwos.Text);



            // Vi måste styra koden
            // antingen är talsumman rätt, eller så är talsumman fel
            // vi kontrollerar tvåor
            if (categoryTwos == 0 || categoryTwos == 2 || categoryTwos == 4 || categoryTwos == 6 || categoryTwos == 8 || categoryTwos == 10)
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
            // vi tilldelar en variabel värdet  från vår metod

            bool[] savedDices = GetSavedDices();
            int[] dices = GameEngine.RollDices(savedDices);
            DisplayDiceValues(dices);
            DisplayDiceValues(dices);
            DisplayDiceValues(dices);
            DisplayDiceValues(dices);
            DisplayDiceValues(dices);
            DisplayDiceValues(dices);
            DisplayDiceValues(dices);
            DisplayDiceValues(dices);
        }

        // Vi gör en metod som skriver ut värdet av våra tärningar.
        // ger metoden en indataparameter = de tärningarna som ska visas
        /// <summary>
        /// Visar tärningarnas värde i våra labels
        /// </summary>
        private void DisplayDiceValues(int[] dicesToDisplay)
        {
            lblDiceOne.Content = dicesToDisplay[1].ToString();
            lblDiceTwo.Content = dicesToDisplay[1].ToString();
            lblDiceThree.Content = dicesToDisplay[2].ToString();
            lblDiceFour.Content = dicesToDisplay[3].ToString();
            lblDiceFive.Content = dicesToDisplay[4].ToString();
        }

        private bool[] GetSavedDices()
        {
            bool[] savedDices =
            {
                chkDiceOne.IsChecked == true,
                chkDiceTwo.IsChecked == true,
                chkDiceThree.IsChecked == true,
                chkDiceFour.IsChecked == true,
                chkDiceFive.IsChecked == true
            };
            return savedDices;
        }






        private void btnFives_Click(object sender, RoutedEventArgs e)
        {

            // här vill vi satsa på våra femmor

            // skapa om möjligt dina variabler lokalt
            int scoreForCategory = 0;
            // Hur gör vi för att samla på någon viss kategori?
            for (int i = 0; i < _dices.Length; i++)
            {
                int diceValue = _dices[i];
                // jag måste undersöka värdet
                if (diceValue == 5)
                {
                    scoreForCategory += diceValue;
                }
            }
            txtFives.Text = scoreForCategory.ToString();
            // om det behövs, lägg variabeln i "stora lådan". Instansvariabel
            _total += scoreForCategory;
            txtTotal.Text = _total.ToString();
        }

        private void btnSixes_Click(object sender, RoutedEventArgs e)
        {
            // här vill vi satsa på våra sexor
            int total = 0;
            // Hur gör vi för att samla på någon viss kategori?
            for (int i = 0; i < _dices.Length; i++)
            {
                int diceValue = _dices[i];
                // jag måste undersöka värdet
                if (diceValue == 6)
                {
                    total += diceValue;
                }
            }
            txtSixes.Text = total.ToString();
            _total += total;
            txtTotal.Text = _total.ToString();
        }


        // hemläxa
        // Jag vill få veta vilken tärning som är den högsta
        // och även vilken som är den lägsta

        // svår extrakod
        // vilka nummer är det som är unika, alltså som förekommer en och endast en gång
    }
}