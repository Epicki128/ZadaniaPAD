namespace QuadraticEquation1
{
    public partial class MainPage : ContentPage
    {
        private string baseResult = "y = 3x^2 + 2x - 2";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            double x;
            double.TryParse(EntryNumber.Text.ToString(), out x);

            string result = baseResult;

            result += $"\ny = 3*{Math.Pow(x, 2)} + {2 * x} - 2";
            result += $"\ny = {3 * Math.Pow(x, 2)} + {(2 * x) - 2}";
            result += $"\ny = {(3 * Math.Pow(x, 2)) + (2 * x) - 2}";

            LabelResult.Text = result;
        }
    }
}
