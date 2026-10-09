
namespace MidTermProject.Views;

public partial class Product2DetailPage : ContentPage
{
    public Product2DetailPage()
    {
        InitializeComponent();
    }

    void OnAddClicked(object sender, EventArgs e)
    {
        var t = QuantityEntry.Text;
        int q;
        if (!int.TryParse(t, out q))
        {
            MessageLabel.Text = "Enter a number between 1 and 99.";
            MessageLabel.TextColor = Colors.PaleGoldenrod;
            return;
        }
        if (q < 1 || q > 99)
        {
            MessageLabel.Text = "Enter a number between 1 and 99.";
            MessageLabel.TextColor = Colors.PaleGoldenrod;
            return;
        }
        MessageLabel.Text = "Added " + q + " x Mana Elixir.";
        MessageLabel.TextColor = Colors.MediumSpringGreen;
    }
}
