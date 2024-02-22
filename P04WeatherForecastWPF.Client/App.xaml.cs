using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using P04WeatherForecastWPF.Client.MessageBox;
using P04WeatherForecastWPF.Client.Services;
using P04WeatherForecastWPF.Client.ViewModels;
using P06Shop.Shared.Confguration;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.ProductService;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace P04WeatherForecastWPF.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IServiceProvider _serviceProvider;
        IConfiguration _configuration;
        public App()
        {
            var builder = new ConfigurationBuilder()
              .AddUserSecrets<App>()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json");
            _configuration = builder.Build();


            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

        }

        private void ConfigureServices(IServiceCollection services)
        {
            var appSettings = ConfigureAppSettings(services);
            ConfigureAppServices(services, appSettings);
            ConfigureViewModels(services);
            ConfigureViews(services);
            ConfigureHttpClients(services, appSettings);

        }

        private AppSettings ConfigureAppSettings(IServiceCollection services)
        {
            //pobranie ustawień z pliku konfiguracyjnego
            // i zmapowanie ich na obiekt AppSettings
            //potrzebujemy pakietu Microsoft.Extensions.Options.ConfigurationExtensions
            var appSettingsSection = _configuration.GetSection(nameof(AppSettings));
            var settings = appSettingsSection.Get<AppSettings>();
            services.Configure<AppSettings>(appSettingsSection); // zarejestrowanie AppSettings w kontenerze DI
            return settings;
        }

        private void ConfigureViewModels(IServiceCollection services)
        {
            // tutaj konfigurujemy viewmodele
            services.AddSingleton<IMainViewModel, MainViewModelV3>();
            services.AddSingleton<SecondWindowViewModel>();
            services.AddSingleton<ProductsViewModel>();
        }

        private void ConfigureAppServices(IServiceCollection services, AppSettings appSettings)
        {
            // tutaj konfigurujemy serwisy
            //  services.AddSingleton<IAccuWeatherService, AccuWeatherService>(); 
            services.AddSingleton<IAccuWeatherService, FakeAccuWeatherService>(); // bo wystraczy nam tylko 1 serwis na cala aplikacje 
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IMessageDialogService, WpfMessageDialogService>();
            services.AddSingleton<ISpeechService>(_ => new SpeechService(appSettings.SpeechSettings));
        }

        private void ConfigureViews(IServiceCollection services)
        {
            // tutaj konfigurujemy widoki
            services.AddTransient<MainWindow>();
            services.AddTransient<SecondWindow>();
            services.AddTransient<ShopProductsView>();
            services.AddTransient<ProductDetailsView>();
        }

        private void ConfigureHttpClients(IServiceCollection services, AppSettings appSettings)
        {
            // tutaj konfigurujemy HttpClient

            var urliBulder = new UriBuilder(appSettings.BaseApiUrl)
            {
                Path = appSettings.ProductEndpoint.BaseUrl
            };

            //żeby skonfigurować HttpClienta, musimy dodać pakiet Microsoft.Extensions.Http
            services.AddHttpClient<IProductService, ProductService>(client => client.BaseAddress = urliBulder.Uri);
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }

}
