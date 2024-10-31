namespace DemoPageNavigation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Wrap the MainPage in a NavigationPage
            // to enable navigation
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
