using BloomBeauty.Services;
using CommunityToolkit.Mvvm;
using Microsoft.Maui.Controls.Hosting;

namespace BloomBeauty;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .Services.AddSingleton<ProductService>()
            .AddSingleton<CartService>()
            .AddSingleton<MainPage>()
            .AddSingleton<CartPage>()
            .AddSingleton<FavoritesPage>()
            .AddSingleton<ProfilePage>();

        return builder.Build();
    }
}
