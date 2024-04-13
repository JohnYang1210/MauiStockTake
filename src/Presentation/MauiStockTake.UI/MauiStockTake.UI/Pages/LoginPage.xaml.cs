using MauiStockTake.UI.Services;

namespace MauiStockTake.UI.Pages;

public partial class LoginPage : ContentPage
{
	private readonly IAuthService _authService;
	public LoginPage()
	{
		InitializeComponent();
		_authService = new AuthService();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		LoginBtn.IsEnabled = false;
		LoggingIn.IsVisible = true;
		var loggedIn = await _authService.LoginAsync();
		LoggingIn.IsVisible = false;
		if (!loggedIn)
		{
			await App.Current.MainPage.DisplayAlert("Error", "Something went wrong logging you in.", "OK");
			LoginBtn.IsEnabled = true;
		}
		else
		{
			//navigate back to the app
			await Navigation.PopModalAsync();
		}
    }
}