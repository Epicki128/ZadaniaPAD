namespace QuadraticEquation2
{
    public partial class MainPage : ContentPage
    {
        private string baseResult = "y = ax^2 + bx + c";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            double x, a, b, c;
            double.TryParse(EntryX.Text.ToString(), out x);
            double.TryParse(EntryA.Text.ToString(), out a);
            double.TryParse(EntryB.Text.ToString(), out b);
            double.TryParse(EntryC.Text.ToString(), out c);

            string result = baseResult;

            result += $"\ny = {a}*{x}^2 + {b}*{x} {(c >= 0 ? "+ " + c : c)}";
            result += $"\ny = {a}*{Math.Pow(x, 2)} + {b * x} {(c >= 0 ? "+ " + c : c)}";
            result += $"\ny = {a * Math.Pow(x, 2)} + {(b * x) + c}";
            result += $"\ny = {(a * Math.Pow(x, 2)) + (b * x) - c}";

            LabelResult.Text = result;
        }
    }
}
