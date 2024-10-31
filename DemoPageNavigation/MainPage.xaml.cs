namespace DemoPageNavigation
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }

}
