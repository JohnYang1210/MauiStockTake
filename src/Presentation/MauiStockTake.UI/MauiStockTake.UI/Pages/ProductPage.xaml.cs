
using MauiStockTake.Shared.Products;

namespace MauiStockTake.UI.Pages;

[QueryProperty(nameof(Product),nameof(Product))]
public partial class ProductPage : ContentPage
{
	string _manufactureName;
	public string ManufactureName
	{
		get => _manufactureName;
		set
		{
			_manufactureName = value;
			OnPropertyChanged();
		}
	}
	string _productName;
	public string ProductName
	{
		get => _productName;
		set
		{
			_productName = value;
			OnPropertyChanged();
		}
	}
	ProductDto _product;
	public ProductDto Product
	{
		get => _product;
		set
		{
			_product = value;
			ProductName=_product.Name;
            ManufactureName = _product.ManufacturerName;
		}
	}
	public ProductPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
}