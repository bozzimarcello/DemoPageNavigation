namespace DemoPageNavigation
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            itemsList.ItemsSource = null;
            itemsList.ItemsSource = ItemsManager.Items;
        }

        private async void OnAddClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemDetailPage());
        }

        private async void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Item selectedItem)
            {
                // Clear selection
                itemsList.SelectedItem = null;

                // Navigate to edit page
                await Navigation.PushAsync(new ItemDetailPage(selectedItem));
            }
        }
    }

}
