using Blazored.Modal;
using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace Portfolio
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            // Register "Head Element Helper" service
            builder.Services.AddHeadElementHelper();
            // Adds all Fluxor dependencies, and scans the specified assembly for any Fluxor related code (states, reducers, etc)
            builder.Services.AddFluxor(o =>
                o.ScanAssemblies(typeof(Program).Assembly));
            // add blazored Modal
            builder.Services.AddBlazoredModal();
            // Add browser service
            builder.Services.AddScoped<BrowserService>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}
