using CarListingApp.MAUI.UI.Models;
using CarListingApp.MAUI.UI.Views;
using CommunityToolkit.Mvvm.Input;

namespace CarListingApp.MAUI.UI.ViewModels;

public partial class LogoutViewModel : BaseViewModel
{
    public LogoutViewModel()
    {
        Logout();
    }

    [RelayCommand]
    private void Logout()
    {
        SecureStorage.Remove("token");
        App.UserInfo = new UserInfoDto();
        Task.Run(() => Shell.Current.GoToAsync($"{nameof(LoginPage)}"));
    }
}
