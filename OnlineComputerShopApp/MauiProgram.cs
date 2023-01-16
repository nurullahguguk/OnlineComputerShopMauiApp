using OnlineComputerShopApp.Data_Transactions;

namespace OnlineComputerShopApp;

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
            });

        string _DbPath = Path.Combine(FileSystem.AppDataDirectory, "Databaseee.db");

        builder.Services.AddSingleton(s =>
        ActivatorUtilities.CreateInstance<DbTrans>(s, _DbPath));

        return builder.Build();
    }
}

