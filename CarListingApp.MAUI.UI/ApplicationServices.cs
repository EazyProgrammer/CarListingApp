using CarListingApp.MAUI.UI.Services;
using CarListingApp.MAUI.UI.ViewModels;
using CarListingApp.MAUI.UI.Views;

namespace CarListingApp.MAUI.UI
{
    public static class ApplicationServices
    {

        public static IServiceCollection ConfigureServiceCollections(this IServiceCollection services)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "cars.db3");
            services.AddSingleton(s => ActivatorUtilities.CreateInstance<CarDatabaseService>(s, dbPath));

            services.AddTransient<CarApiService>();

            services.AddSingleton<CarListViewModel>();
            services.AddTransient<LoadingViewModel>();
            services.AddTransient<LoginViewModel>();
            services.AddTransient<CarDetailsViewModel>();
            services.AddTransient<LogoutViewModel>();

            services.AddTransient<LoadingPage>();
            services.AddTransient<LoginPage>();
            services.AddTransient<CarDetailsPage>();
            services.AddTransient<LogoutPage>();
            services.AddSingleton<MainPage>();

            return services;
        }
    }
}
