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
            // _dices = new int[5];
            // här kastar vi alltid alla tärningar
            //for (int i = 0; i < _dices.Length; i++)
            //{
            //    _dices[i] = _random.Next(1, 7);
            //}

            // vi vill kunna spara tärningar
            //bool rollDiceOne = chkDiceOne.IsChecked == true;

            // Gör så Erik blir smart!
            // varför inte skapa en array till!
            // sparade tärningar:
            //  0      1      2     3     4
            // [true, false, true, true, true]
            // [2,    5,      5,    5,     6]
            bool[] savedDices = new bool[_dices.Length];
            savedDices[0] = chkDiceOne.IsChecked == true;
            savedDices[1] = chkDiceTwo.IsChecked == true;
            savedDices[2] = chkDiceThree.IsChecked == true;
            savedDices[3] = chkDiceFour.IsChecked == true;
            savedDices[4] = chkDiceFive.IsChecked == true;


            // Vi skulle kunna testa att göra en kontroll av en array till!
            for (int i = 0; i < _dices.Length; i++)
            {
                bool diceIsNotSaved = savedDices[i] == false;
                if (diceIsNotSaved)
                {
                    _dices[i] = _random.Next(1, 7);
                }
            }

            lblDiceOne.Content = _dices[0].ToString();
            lblDiceTwo.Content = _dices[1].ToString();
            lblDiceThree.Content = _dices[2].ToString();
            lblDiceFour.Content = _dices[3].ToString();
            lblDiceFive.Content = _dices[4].ToString();

            // hemläxa
            // använd en for-loop för att summera värdena från alla tärningar
            int total = 0;
            for (int i = 0; i < _dices.Length; i++)
            {
                // total = total + dices[i]
                total += _dices[i];
            }


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