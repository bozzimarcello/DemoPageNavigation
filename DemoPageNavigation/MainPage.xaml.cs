namespace DemoPageNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateClicked(object sender, EventArgs e)
        {
            // Create a user object with the input data
            var userData = new UserData
            {
                Name = userNameEntry.Text ?? "No name",
                Age = int.TryParse(userAgeEntry.Text, out int age) ? age : 0
            };

            // Navigate and pass the data
            await Navigation.PushAsync(new DetailsPage(userData));
        }
    }

}
