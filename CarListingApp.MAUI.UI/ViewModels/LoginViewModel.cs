
using CarListingApp.MAUI.UI.Helpers;
using CarListingApp.MAUI.UI.Models;
using CarListingApp.MAUI.UI.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CarListingApp.MAUI.UI.ViewModels;

public partial class LoginViewModel : BaseViewModel
{
    private readonly CarApiService _carApiService;

    [ObservableProperty]
    public string userName;

    [ObservableProperty]
    public string password;

    public LoginViewModel(CarApiService carApiService)
    {
        _carApiService = carApiService;
    }

    [RelayCommand]
    public async Task Login()
    {
        if (string.IsNullOrEmpty(UserName) || string.IsNullOrWhiteSpace(Password))
        {
            //display welcome message
            await DisplayLoginError();
            return;
        }

        //Call api to attempt login
        var loginModel = new LoginDto(UserName, Password);
        var response = await _carApiService.Login(loginModel);

        if (response == null || string.IsNullOrEmpty(response.Token))
        {
            //display welcome message
            await DisplayLoginError();
            return;
        }

        //store token in secure storage
        await SecureStorage.SetAsync("token", response.Token);

        //configure user info
        var jsonToken = new JwtSecurityTokenHandler().ReadToken(response.Token) as JwtSecurityToken;

        App.UserInfo = new UserInfoDto()
        {
            UserName = jsonToken.Claims.FirstOrDefault(q => q.Type.Equals(JwtRegisteredClaimNames.Email))?.Value,
            Role = jsonToken.Claims.FirstOrDefault(q => q.Type.Equals(ClaimTypes.Role))?.Value
        };

        //display welcome message
        //await DisplayLoginSuccess(_carApiService.statusMessage);

        //build a menu on the fly based on the user role
        await MenuBuilder.BuildMenu();

        await Shell.Current.GoToAsync($"{nameof(MainPage)}");
    }

    private async Task DisplayLoginError()
    {
        await Shell.Current.DisplayAlert("Invalid Login Attempt", "Invalid username / password", "OK");
        Password = string.Empty;
    }

    private async Task DisplayLoginSuccess(string message)
    {
        await Shell.Current.DisplayAlert("User Login", message, "OK");
        Password = string.Empty;
    }
}
