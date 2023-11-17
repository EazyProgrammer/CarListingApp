
using CarListingApp.MAUI.UI.Controls;
using CarListingApp.MAUI.UI.Struct;
using CarListingApp.MAUI.UI.Views;

namespace CarListingApp.MAUI.UI.Helpers;

public static class MenuBuilder
{
    public async static Task BuildMenu()
    {
        Shell.Current.Items.Clear();
        Shell.Current.FlyoutHeader = new FlyoutHeader();

        var role = App.UserInfo.Role;

        switch (role)
        {
            case Roles.Administrator:
                var adminItems = await GetAdministratorItems();

                if (!Shell.Current.Items.Contains(adminItems))
                    Shell.Current.Items.Add(adminItems);

                break;

            case Roles.User:
                var userItems = await GetUserItems();

                if (!Shell.Current.Items.Contains(userItems))
                    Shell.Current.Items.Add(userItems);
                break;

            default:
                break;
        }
    }

    private async static Task<FlyoutItem> GetAdministratorItems()
    {
        return await Task.Run(() => new FlyoutItem()
        {
            Title = "Administrator Car Management",
            Route = nameof(MainPage),
            FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
            Items =
            {
                new ShellContent
                {
                    Icon = "dotnet_bot.svg",
                    Title = "Admin Page 1",
                    ContentTemplate = new DataTemplate(typeof(MainPage))
                },
                GetLogoutItem()
            }
        });
    }

    private async static Task<FlyoutItem> GetUserItems()
    {
        return await Task.Run(() => new FlyoutItem()
        {
            Title = "User Car Management",
            Route = nameof(MainPage),
            FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
            Items =
            {
                new ShellContent
                {
                    Icon = "dotnet_bot.svg",
                    Title = "User Page 1",
                    ContentTemplate = new DataTemplate(typeof(MainPage))
                },
                GetLogoutItem()
            }
        });
    }

    private static ShellContent GetLogoutItem()
    {
        return new ShellContent
        {
            Icon = "dotnet_bot.svg",
            Title = "Logout",
            ContentTemplate = new DataTemplate(typeof(LogoutPage))
        };
    }
}
