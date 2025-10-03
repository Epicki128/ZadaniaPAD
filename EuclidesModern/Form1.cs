namespace EuclidesModern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> recent = new List<string>() { "" };
        private int count = 0;

        /*
        * Nazwa: EuclidesAlgorithm (Alorytm Euklidesa)
        * Parametry: uint a, uint b
        * Zwracany typ: uint
        * Opis: Funkcja zwraca najwiêkszy wspólny dzielnik dwóch liczb ca³kowitych dodatnich a i b, wykorzystuj¹c algorytm Euklidesa.
       */
        static uint EuclidesAlgorihtm(uint a, uint b)
        {
            uint nwd;

            while (b != 0)
            {
                uint temp = a % b;
                a = b;
                b = temp;
            }

            nwd = a;

            return nwd;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            uint a = (uint)Math.Abs(int.Parse(valueA.Text));
            uint b = (uint)Math.Abs(int.Parse(valueB.Text));

            uint nwd;

            if (a == 0 && b == 0)
            {
                MessageBox.Show("NWD nieokreœlone, \n A i B s¹ równe 0");
                return;
            }
            else if (a == 0 && b != 0)
            {
                nwd = b;
            }
            else if (a != 0 && b == 0)
            {
                nwd = a;
            }
            else
            {
                nwd = EuclidesAlgorihtm(a, b);
            }

            string resultString = $"NWD({a}, {b}) = {nwd}";
            if (!resultString.Equals(recent.Last()))
            {
                count = 0;
                recent.Add(resultString);
                Ostatnie.Items.Add(resultString);
            }
            else
            {
                count++;
                Ostatnie.Items[Ostatnie.Items.Count - 1] = $"{resultString} [x{count}]";
            }

            result.Text = nwd.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            recent = new List<string>() { "" };
            Ostatnie.Items.Clear();
            result.Text = "";
            valueA.Text = "";
            valueB.Text = "";
        }
    }
}
