using CarListingApp.MAUI.UI.ViewModels;

namespace CarListingApp.MAUI.UI.Views;

public class LogoutPage : ContentPage
{
	public LogoutPage(LogoutViewModel logoutViewModel)
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { 
					HorizontalOptions = LayoutOptions.Center, 
					VerticalOptions = LayoutOptions.Center, 
					Text = "Logging Out, please wait .."
				}
			}
		};

		BindingContext = logoutViewModel;
    }
}