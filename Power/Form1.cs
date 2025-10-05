namespace Power
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int counter = 0;

        private void CTArecurention_Click(object sender, EventArgs e)
        {
            counter = 0;
            int inputValue = int.Parse(input.Text);
            int result = PowerRecursion(inputValue);
            resultOutput.Text = result.ToString();
            stepsCount.Text = counter.ToString();
        }

        private int PowerRecursion(int factorial)
        {
            counter++;
            if (factorial == 0 || factorial == 1) return 1;
            else return factorial * PowerRecursion(factorial - 1);
        }

        private void CTAloop_Click(object sender, EventArgs e)
        {
            counter = 0;
            int inputValue = int.Parse(input.Text);
            int result;

            for (result = 1; inputValue > 0; inputValue--)
            {
                counter++;
                result *= inputValue;
            }
            resultOutput.Text = result.ToString();
            stepsCount.Text = counter.ToString();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            input.Text = "";
            resultOutput.Text = "";
            stepsCount.Text = "";
            counter = 0;
        }

    }
}
