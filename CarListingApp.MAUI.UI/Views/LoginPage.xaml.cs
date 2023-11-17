using CarListingApp.MAUI.UI.ViewModels;

namespace CarListingApp.MAUI.UI.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel viewModel)
    {
        InitializeComponent();

		this.BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Shell.SetTabBarIsVisible(this, false);
    }
}
