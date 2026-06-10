using BloomBeauty.Models;
using BloomBeauty.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BloomBeauty;

public partial class MainPage : ContentPage
{
    private readonly ProductService _productService;
    private readonly CartService _cartService;

    public MainPage()
    {
        InitializeComponent();
        
        _productService = new ProductService();
        _cartService = new CartService();
        
        BindingContext = new MainPageViewModel(_productService, _cartService);
    }
}

public partial class MainPageViewModel : ObservableObject
{
    private readonly ProductService _productService;
    private readonly CartService _cartService;

    [ObservableProperty]
    private ObservableCollection<Product> newProducts;

    [ObservableProperty]
    private ObservableCollection<Product> viralProducts;

    [ObservableProperty]
    private ObservableCollection<CarouselItem> carouselItems;

    [ObservableProperty]
    private ObservableCollection<ServiceItem> services;

    [ObservableProperty]
    private Product selectedProduct;

    [RelayCommand]
    public void AddToCart(Product product)
    {
        _cartService.AddToCart(product);
        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await Application.Current.MainPage.DisplayAlert("Éxito", $"{product.Name} añadido al carrito", "OK");
        });
    }

    [RelayCommand]
    public void ProductSelected(Product product)
    {
        if (product != null)
        {
            SelectedProduct = product;
        }
    }

    public MainPageViewModel(ProductService productService, CartService cartService)
    {
        _productService = productService;
        _cartService = cartService;

        LoadData();
    }

    private void LoadData()
    {
        NewProducts = new ObservableCollection<Product>(_productService.GetNewProducts());
        ViralProducts = new ObservableCollection<Product>(_productService.GetViralProducts());

        CarouselItems = new ObservableCollection<CarouselItem>
        {
            new CarouselItem { ImageUrl = "https://i.pinimg.com/1200x/4a/25/0e/4a250e72f5f2a51836024051c3b4b30a.jpg" },
            new CarouselItem { ImageUrl = "https://i.pinimg.com/1200x/4a/25/0e/4a250e72f5f2a51836024051c3b4b30a.jpg" },
            new CarouselItem { ImageUrl = "https://i.pinimg.com/1200x/4a/25/0e/4a250e72f5f2a51836024051c3b4b30a.jpg" },
        };

        Services = new ObservableCollection<ServiceItem>
        {
            new ServiceItem 
            { 
                ImageUrl = "https://i.pinimg.com/736x/03/bc/7b/03bc7beff29cf82f8ca88e13ca83d0ba.jpg",
                Description = "Creamos una rutina ideal para tu tipo de piel con nuestros productos"
            },
            new ServiceItem 
            { 
                ImageUrl = "https://i.pinimg.com/736x/0a/d8/2b/0ad82b0fce67d8b604bf7d03f535330e.jpg",
                Description = "Aprende a aplicar maquillaje y a sacar el máximo partido a nuestros productos."
            },
            new ServiceItem 
            { 
                ImageUrl = "https://i.pinimg.com/736x/d2/a6/ec/d2a6ecabfc4aa970d6240cc490cd8337.jpg",
                Description = "Recibe tus productos de forma rápida y segura en cualquier lugar del país"
            }
        };
    }
}

public class CarouselItem
{
    public string ImageUrl { get; set; }
}

public class ServiceItem
{
    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
