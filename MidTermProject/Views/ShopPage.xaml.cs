namespace MidTermProject.Views;

public partial class ShopPage : ContentPage
{
    public ShopPage()
    {
        InitializeComponent();
        ProductsView.ItemsSource = new[]{
"Healing Potion","Mana Elixir","Firebomb Vial","Shadow Tonic"
};
    }

    void OnProductSelected(object sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as string;
        if (item == null) return;
        if (item == "Healing Potion") Shell.Current.GoToAsync(nameof(Product1DetailPage));
        else if (item == "Mana Elixir") Shell.Current.GoToAsync(nameof(Product2DetailPage));
        else if (item == "Firebomb Vial") Shell.Current.GoToAsync(nameof(Product3DetailPage));
        else if (item == "Shadow Tonic") Shell.Current.GoToAsync(nameof(Product4DetailPage));
        ((CollectionView)sender).SelectedItem = null;
    }
}
