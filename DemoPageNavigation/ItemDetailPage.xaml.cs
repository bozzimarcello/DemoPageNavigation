namespace DemoPageNavigation;

public partial class ItemDetailPage : ContentPage
{
    private Item _editingItem;
    private bool _isEditing;

    public ItemDetailPage(Item itemToEdit = null)
    {
        InitializeComponent();

        if (itemToEdit != null)
        {
            _editingItem = itemToEdit;
            _isEditing = true;
            LoadItem();
            Title = "Edit Item";
        }
        else
        {
            Title = "Add New Item";
        }
    }

    private void LoadItem()
    {
        titleEntry.Text = _editingItem.Title;
        descriptionEntry.Text = _editingItem.Description;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(titleEntry.Text))
        {
            await DisplayAlert("Error", "Please enter a title", "OK");
            return;
        }

        if (_isEditing)
        {
            // Update existing item
            _editingItem.Title = titleEntry.Text;
            _editingItem.Description = descriptionEntry.Text ?? string.Empty;
            ItemsManager.UpdateItem(_editingItem);
        }
        else
        {
            // Create new item
            var newItem = new Item
            {
                Title = titleEntry.Text,
                Description = descriptionEntry.Text ?? string.Empty
            };
            ItemsManager.AddItem(newItem);
        }

        await Navigation.PopAsync();
    }
}