namespace QuadraticEquation4
{
    public partial class MainPage : ContentPage
    {
        private string baseResult = "y = ax² + bx + c";
        private string baseDelta = "Δ = b² - 4ac";
        private string baseZeros1 = "x₁ = ( -b - √Δ) / 2a  | x₂ = ( -b + √Δ) / 2a";
        private string baseZeros2 = "x₁ = x₂ = - b / 2a";
        private string baseVertexX = "W(x) = -b / 2a";
        private string baseVertexY = "W(y) = -Δ; / 4a";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            double x = 0, a = 0, b = 0, c = 0;
            double.TryParse(EntryX.Text.ToString(), out x);
            double.TryParse(EntryA.Text.ToString(), out a);
            double.TryParse(EntryB.Text.ToString(), out b);
            double.TryParse(EntryC.Text.ToString(), out c);

            string result = baseResult;

            result += $"\ny = {a}*{x}² + {b}*{x} {(c >= 0 ? "+ " + c : c)}";
            result += $"\ny = {a}*{Math.Pow(x, 2)} + {b * x} {(c >= 0 ? "+ " + c : c)}";
            result += $"\ny = {a * Math.Pow(x, 2)} + {(b * x) + c}";
            result += $"\ny = {(a * Math.Pow(x, 2)) + (b * x) - c}";

            LabelResult.Text = result;

            string delta = baseDelta;

            delta += $"\nΔ = {b}² - 4*{a}*{c}";
            delta += $"\nΔ = {Math.Pow(b, 2)} - 4*{a * c}";
            delta += $"\nΔ = {Math.Pow(b, 2)} - {4 * a * c}";
            delta += $"\nΔ = {Math.Pow(b, 2) - 4 * a * c}";

            LabelDelta.Text = delta;

            double D = Math.Pow(b, 2) - 4 * a * c;

            string zeros;

            if (D > 0)
            {
                zeros = baseZeros1;
                zeros += $"\nx₁ = ( {-b} - √{D}) / 2*{a}  | x₂ = ( {-b} + √{D}) / 2*{a}";
                zeros += $"\nx₁ = ( {-b} - {Math.Sqrt(D)}) / {2 * a}  | x₂ = ( {-b} + {Math.Sqrt(D)}) / {2 * a}";
                zeros += $"\nx₁ = {-b - Math.Sqrt(D)} / {2 * a}  | x₂ = {-b + Math.Sqrt(D)} / {2 * a}";
                zeros += $"\nx₁ = {(-b - Math.Sqrt(D)) / 2 * a}  | x₂ = {(-b + Math.Sqrt(D)) / 2 * a}";

            }
            else if (D == 0)
            {
                zeros = baseZeros2;
                zeros += $"\nx₁ = x₂ = {-b} / 2*{a}";
                zeros += $"\nx₁ = x₂ = {-b} / {2 * a}";
                zeros += $"\nx₁ = x₂ = {-b / (2 * a)}";
            }
            else
            {
                zeros = "Brak miejsc zerowych";
            }

            LabelZeros.Text = zeros;

            string vertexX = baseVertexX;

            vertexX += $"\nW(x) = {-b} / 2*{a}";
            vertexX += $"\nW(x) = {-b} / {2 * a}";
            vertexX += $"\nW(x) = {-b / (2 * a)}";

            LabelVertexX.Text = vertexX;

            string vertexY = baseVertexY;

            vertexY += $"\nW(y) = {-D} / 4*{a}";
            vertexY += $"\nW(y) = {-D} / {4 * a}";
            vertexY += $"\nW(y) = {-D / (4 * a)}";

            LabelVertexY.Text = vertexY;

            GraphicsViewGraph.Drawable = new QuadraticDrawable(a, b, c);
        }
    }

    // Klasa wykresu funkcji kwadratowej
    public class QuadraticDrawable : IDrawable
    {
        private double _a;
        private double _b;
        private double _c;

        public QuadraticDrawable(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        //funkcja rysująca wykres i funkcję kwadratową
        public void Draw(ICanvas canvas, RectF plainRect)
        {
            canvas.FillColor = Colors.White;
            canvas.FillRectangle(plainRect);

            float width = plainRect.Width;
            float height = plainRect.Height;

            canvas.StrokeColor = Colors.Black;
            canvas.StrokeSize = 2;

            canvas.DrawLine(0, height / 2, width, height / 2);

            canvas.DrawLine(width / 2, 0, width / 2, height);

            canvas.StrokeColor = Colors.Blue;
            canvas.StrokeSize = 3;

            float scale = 20f;

            for (float x = -width / 2; x < width / 2; x += 1)
            {
                double mathX = x / scale;
                double mathY = _a * mathX * mathX + _b * mathX + _c;

                float screenX = width / 2 + x;
                float screenY = height / 2 - (float)(mathY * scale);

                if (x > -width / 2)
                {
                    float prevMathX = (x - 1) / scale;
                    double prevMathY = _a * prevMathX * prevMathX + _b * prevMathX + _c;

                    float prevScreenX = width / 2 + (x - 1);
                    float prevScreenY = height / 2 - (float)(prevMathY * scale);

                    canvas.DrawLine(prevScreenX, prevScreenY, screenX, screenY);
                }
            }
        }
    }
}
