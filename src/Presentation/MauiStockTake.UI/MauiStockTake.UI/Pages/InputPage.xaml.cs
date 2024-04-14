
using MauiStockTake.Shared.Products;

namespace MauiStockTake.UI.Pages;

public partial class InputPage : ContentPage
{
	public InputPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		var product = new ProductDto
        {
			Name="MauiStockTake",
			ManufacturerName="JohnYangBytes"
		};
		var pageParams = new Dictionary<string, object>
		{
			["Product"]=product
		};
		await Shell.Current.GoToAsync("productdetails",pageParams);
    }
}