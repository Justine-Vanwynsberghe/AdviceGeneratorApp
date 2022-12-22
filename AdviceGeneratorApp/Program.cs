using AdviceGeneratorApp;
using AdviceGeneratorApp.ApiService;
using AdviceGeneratorApp.ApiService.Interfaces;
using AdviceGeneratorApp.Models;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => 
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    });


builder.Services.AddScoped<IApiConnector<Root>, ApiConnector<Root>>();
await builder.Build().RunAsync();
