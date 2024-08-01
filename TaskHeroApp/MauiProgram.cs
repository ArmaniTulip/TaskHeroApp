using Microsoft.Extensions.Logging;
using TaskHeroApp.View;
using TaskHeroApp.ViewModel;

namespace TaskHeroApp
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
                });

            builder.Services.AddSingleton<MainPage> ();
            builder.Services.AddSingleton<MainViewModel> ();

            builder.Services.AddTransient<TaskDetailsPage>();
            builder.Services.AddTransient<TaskDetailsPageViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
