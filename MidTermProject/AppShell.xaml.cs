using MidTermProject.Views;

namespace MidTermProject;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(Product1DetailPage), typeof(Product1DetailPage));
        Routing.RegisterRoute(nameof(Product2DetailPage), typeof(Product2DetailPage));
        Routing.RegisterRoute(nameof(Product3DetailPage), typeof(Product3DetailPage));
        Routing.RegisterRoute(nameof(Product4DetailPage), typeof(Product4DetailPage));
    }
}
