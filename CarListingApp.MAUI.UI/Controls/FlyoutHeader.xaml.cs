namespace CarListingApp.MAUI.UI.Controls;

public partial class FlyoutHeader : StackLayout
{
    public FlyoutHeader()
    {
        InitializeComponent();

        SetValues();
    }

    private void SetValues()
    {
        if (App.UserInfo != null)
        {
            lblUserName.Text = App.UserInfo.UserName;
            lblRole.Text = App.UserInfo.Role;
        }
    }
}