using System.Text.RegularExpressions;

namespace SendParcel
{
    public partial class MainPage : ContentPage
    {
        private int parcelType = 1;
        private string[,] types = { { "pocztowka.png", "Cena: 1zł" }, { "list.png", "Cena: 1,50zł" }, { "paczka.png", "Cena: 10zł" } };
        private string postalCodeTemplate = @"^\d{2}-\d{3}$";
        public MainPage()
        {
            InitializeComponent();
        }

        private void setParcelType(object sender, CheckedChangedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            parcelType = int.Parse(rb.Value?.ToString());
        }

        private void getParcelType(object sender, EventArgs e)
        {
            Icon.Source = ImageSource.FromFile(types[parcelType, 0]);
            Price.Text = types[parcelType, 1];
        }

        private void Submit(object sender, EventArgs e)
        {
            if (Regex.IsMatch($"{EntPostalCode.Text}", postalCodeTemplate)) DisplayAlert("Zatwierdzono!", "Dane przesyłki zostały wprowadzone", "OK");
            else DisplayAlert("Wystąpił błąd!", "Kod pocztowy nie jest poprawny", "OK");
        }
    }
}
