using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Inventory_Management_FINAL;
using Inventory_Management_FINAL.InventoryApp;
using Inventory_Management_FINAL.ECommerce;
using Inventory_Management_FINAL.ECommerce1;
using Inventory_Management_FINAL.Northwind;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IInventoryAppService>(sp => new InventoryAppService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<IECommerceService>(sp => new ECommerceService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<IECommerce1Service>(sp => new ECommerce1Service(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<INorthwindService>(sp => new NorthwindService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbCardModule),
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbPieChartModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbInputModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbIconButtonModule),
        typeof(IgbGridModule)
    );
}