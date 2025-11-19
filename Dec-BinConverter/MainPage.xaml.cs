namespace Dec_BinConverter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Convert(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;

            if (sender.Equals(EntDecimal))
            {
                int number = int.TryParse(text, out int r) ? r : 0;

                string bin = "";

                for (int i = findFirstVal(number), temp = number; i >= 1; i /= 2)
                {
                    if (temp > i || i == 1 && temp == i)
                    {
                        bin += 1;
                        temp -= i;
                    }
                    else bin += 0;
                }

                bin = bin.TrimStart('0');

                EntBinary.Text = bin;

            }
            else
            {
                int val = findFirstVal((int)Math.Pow(2, text.Length - 1));

                int dec = 0;

                foreach (char c in text)
                {
                    int number = int.TryParse(c.ToString(), out int r) ? r : 0;

                    if (number == 1) dec += val;

                    val /= 2;
                }

                EntDecimal.Text = dec.ToString();
            }
        }

        private int findFirstVal(int num)
        {
            int val = 1;

            do val *= 2;
            while (val <= num);

            val /= 2;
            return val;
        }
    }
}
