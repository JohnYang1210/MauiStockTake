using Maui.Plugins.PageResolver;
using MauiStockTake.Client.Authentication;
using MauiStockTake.UI.Helpers;
using MauiStockTake.UI.Pages;
using MauiStockTake.UI.Services;
using Microsoft.Extensions.Logging;
using IBrowser = IdentityModel.OidcClient.Browser.IBrowser;
namespace MauiStockTake.UI
{
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
                }).UsePageResolver();
            builder.Services.AddSingleton<IBrowser, AuthBrowser>();
            builder.Services.AddSingleton<IAuthService,AuthService>();
            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddSingleton<AuthHandler>();
            builder.Services.AddHttpClient(AuthHandler.AUTHENTICATED_CLIENT).
                AddHttpMessageHandler(s=>s.GetRequiredService<AuthHandler>());

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
