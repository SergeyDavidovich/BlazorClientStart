using BlazorClientStart;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

namespace BlazorClientStart
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Syncfusion components version: 20.3.0.56
            const string LICENSE_KEY = "NzY4MjQ4QDMyMzAyZTMzMmUzMExNbkN6czhDOGhqY2hCSXhyMWpYTnIxbjdhZlgzVWlRN2pGQy9hMzc4WUE9";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(LICENSE_KEY);

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSyncfusionBlazor();


        

        await builder.Build().RunAsync();
        }
    }
}