namespace DemoPageNavigation;

public partial class DetailsPage : ContentPage
{
    private readonly UserData _userData;

    public DetailsPage(UserData userData)
    {
        InitializeComponent();
        _userData = userData;

        // Use the passed data to update the UI
        welcomeLabel.Text = $"Welcome, {_userData.Name}!";
        ageLabel.Text = $"You are {_userData.Age} years old";
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}