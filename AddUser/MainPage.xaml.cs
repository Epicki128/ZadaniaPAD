namespace AddUser
{
    public partial class MainPage : ContentPage
    {

        private string password = "";

        private string name, surname, position;

        private bool useNumerics, useSpecials, useUpperCase;

        private int passwordLength = 8;

        private string[] positions = { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" };

        private string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        private string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string numericChars = "0123456789";
        private string specialChars = "!@#$%^&*()_-+=<>?";

        public MainPage()
        {
            InitializeComponent();
            PositionPicker.ItemsSource = positions;
            PositionPicker.SelectedItem = positions[0];
        }


        private void GeneratePassword(object Sender, EventArgs e)
        {
            password = "";
            if (PassLength.Text != null)
            {
                try
                {
                    passwordLength = int.Parse(PassLength.Text);
                }
                catch
                {
                    passwordLength = 8;
                }
            }
            useNumerics = UseNumerics.IsChecked;
            useSpecials = UseSpecials.IsChecked;
            useUpperCase = UseUpperCase.IsChecked;

            Random random = new Random();

            while (password.Length < passwordLength)
            {
                int temp = random.Next(1, 5);

                if (temp == 1)
                {
                    int i = random.Next(lowerCaseChars.Length);

                    password += lowerCaseChars[i];
                }
                else if (temp == 2 && useNumerics)
                {
                    int i = random.Next(numericChars.Length);

                    password += numericChars[i];
                }
                else if (temp == 3 && useSpecials)
                {
                    int i = random.Next(specialChars.Length);

                    password += specialChars[i];
                }
                else if (temp == 4 && useUpperCase)
                {
                    int i = random.Next(upperCaseChars.Length);

                    password += upperCaseChars[i];
                }
            }

            DisplayAlert("Wygenerowane hasło", password, "OK");
        }

        private void Submit(object Sender, EventArgs e)
        {
            name = Name.Text;
            surname = Surname.Text;
            position = positions[PositionPicker.SelectedIndex];

            DisplayAlert("Dane pracownika", $"{name} {surname}, {position} Hasło: {password}", "OK");
        }
    }
}