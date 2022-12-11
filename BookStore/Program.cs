using BookStore;
using BookStore.Services;
using BookStore.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) }); //copy paste the base url as the argument of the url constructor as  here 

builder.Services.AddScoped<iProductService, ProductService>();

await builder.Build().RunAsync();
