using CarListingApp.MAUI.UI.ViewModels;

namespace CarListingApp.MAUI.UI.Views;

public partial class LoadingPage : ContentPage
{
    public LoadingPage(LoadingViewModel viewModel)
    {
        InitializeComponent();

        this.BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var viewModel = BindingContext as LoadingViewModel;

        await viewModel.CheckUserLoginDetails();
    }
}
