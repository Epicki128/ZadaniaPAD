namespace WebAttacksCatalog
{
    using System.Text.Json;

    public class Attack
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {

            var stream = FileSystem.OpenAppPackageFileAsync("WebAttacks.json");
            var json = new StreamReader(stream.Result).ReadToEnd();
            var attacks = JsonSerializer.Deserialize<List<Attack>>(json);



            InitializeComponent();

            AttacksListView.ItemsSource = attacks;

        }
    }
}
