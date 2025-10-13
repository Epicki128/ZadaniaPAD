using System.Diagnostics;

namespace Fibbonaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long stepCount = 0;
        uint NumberValue = 0;

        Stopwatch stopwatch = new Stopwatch();

        private uint FibLoop(uint n)
        {
            stopwatch.Restart();
            uint fib = 0, a = 0, b = 1;
            stepCount = 0;

            if (n == 0)
            {
                stepCount++;
                return 0;
            }
            else if (n == 1)
            {
                stepCount++;
                return 1;
            }

            for (uint i = 2; i <= n; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
                stepCount++;
            }

            //resultFib.Text = fib.ToString();
            //Steps.Text = stepCount.ToString();

            stopwatch.Stop();
            return fib;
        }

        private uint FibRecurention(uint n)
        {
            stepCount++;
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return FibRecurention(n - 1) + FibRecurention(n - 2);
        }

        private void Btn(object sender, EventArgs e)
        {
            NumberValue = (uint)Math.Abs(int.Parse(Number.Text));

            if (sender.Equals(Recurention))
            {
                stepCount = 0;
                stopwatch.Restart();
                uint fib = FibRecurention(NumberValue);
                stopwatch.Stop();
                resultFib.Text = fib.ToString();
                Steps.Text = stepCount.ToString();
                time.Text = stopwatch.Elapsed.TotalMilliseconds.ToString();
            }
            else if (sender.Equals(Loop))
            {
                uint fib = FibLoop(NumberValue);
                resultFib.Text = fib.ToString();
                Steps.Text = stepCount.ToString();
                time.Text = stopwatch.Elapsed.TotalMilliseconds.ToString();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Number.Text = "";
            resultFib.Text = "";
            Steps.Text = "";
            time.Text = "";
        }
    }
}
