using CarListingApp.MAUI.UI.Models;
using CarListingApp.MAUI.UI.Services;

namespace CarListingApp.MAUI.UI;

public partial class App : Application
{
    public static UserInfoDto UserInfo;
    public static CarDatabaseService _carService { get; private set; }

    public App(CarDatabaseService carService)
    {
        InitializeComponent();

        MainPage = new AppShell();
        _carService = carService;
    }
}