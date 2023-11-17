
using CarListingApp.MAUI.UI.Helpers;
using CarListingApp.MAUI.UI.Models;
using CarListingApp.MAUI.UI.Views;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CarListingApp.MAUI.UI.ViewModels;

public partial class LoadingViewModel : BaseViewModel
{
    public LoadingViewModel()
    {
        //Task.Run(CheckUserLoginDetails);
    }

    public async Task CheckUserLoginDetails()
    {
        //get token from internal storage
        var token = SecureStorage.GetAsync("token").Result;
        
        if (string.IsNullOrEmpty(token))
        {
            await GotoLoginPage();
            return;
        }

        //evaluate token and decide if valid
        var jsonToken = new JwtSecurityTokenHandler().ReadToken(token) as JwtSecurityToken;

        if (jsonToken.ValidTo < DateTime.UtcNow)
        {
            SecureStorage.Remove("token");
            await GotoLoginPage();
            return;
        }

        App.UserInfo = new UserInfoDto()
        {
            UserName = jsonToken.Claims.FirstOrDefault(q => q.Type.Equals(ClaimTypes.Email))?.Value,
            Role = jsonToken.Claims.FirstOrDefault(q => q.Type.Equals(ClaimTypes.Role))?.Value
        };

        await MenuBuilder.BuildMenu();
        await GotoMainPage();
    }

    private async Task GotoLoginPage() => await Shell.Current.GoToAsync($"{nameof(LoginPage)}");

    private async Task GotoMainPage() => await Shell.Current.GoToAsync($"{nameof(MainPage)}");
}
