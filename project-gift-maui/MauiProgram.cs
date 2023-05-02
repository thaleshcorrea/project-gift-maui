using Microsoft.Extensions.Logging;
using DevExpress.Maui;
using CommunityToolkit.Maui;
using System.Runtime.CompilerServices;
using project_gift_maui.Services;
using project_gift_maui.Views;
using project_gift_maui.ViewModels;

namespace project_gift_maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseDevExpress()
            .UseMauiCommunityToolkit()
            .AddServices()
            .AddPages()
            .AddViewModels()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("FontAwesome-Regular.ttf", "FontAwesome_Regular");
                fonts.AddFont("FontAwesome-Solid.ttf", "FontAwesome_Solid");
                fonts.AddFont("Exo-Black.ttf", "Exo_Black");
                fonts.AddFont("Exo-Bold.ttf", "Exo_Bold");
                fonts.AddFont("Exo-Medium.ttf", "Exo_Medium");
                fonts.AddFont("Exo-Regular.ttf", "Exo_Regular");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }

    private static MauiAppBuilder AddServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<IFirebaseAuthentication, FirebaseAuthentication>();

        return builder;
    }

    private static MauiAppBuilder AddPages(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<ApresentacaoPage>();

        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<RegisterPage>();
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<MaisPage>();

        builder.Services.AddTransient<PerfilPage>();

        return builder;
    }

    private static MauiAppBuilder AddViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<ApresentacaoViewModel>();

        builder.Services.AddTransient<LoginViewModel>();
        builder.Services.AddTransient<RegisterViewModel>();
        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<MaisViewModel>();

        builder.Services.AddTransient<PerfilViewModel>();

        return builder;
    }
}
