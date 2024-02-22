using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using P06Shop.Shared.Confguration;
using P06Shop.Shared.Services.ProductService;
using P11BlazorWebAssembly.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var appSettings = builder.Configuration.GetSection(nameof(AppSettings));
var appSettingsSection = appSettings.Get<AppSettings>();

var uriBuilder = new UriBuilder(appSettingsSection.BaseApiUrl)
{
    Path = appSettingsSection.ProductEndpoint.BaseUrl
};
// wymagna paczka: Microsoft.Extensions.Http
builder.Services.AddHttpClient<IProductService, ProductService>(client => client.BaseAddress = uriBuilder.Uri);
builder.Services.Configure<AppSettings>(appSettings);

await builder.Build().RunAsync();
