using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlogWebAssembly.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using MyBlogWebAssembly.Client.Authentication;
using MyBlog.Data.Interfaces;
using MyBlog.Data;
using Blazored.SessionStorage;
using MyBlog.Shared.Interfaces;
using MyBlogWebAssembly.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("Authenticated", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)).AddHttpMessageHandler < BaseAddressAuthorizationMessageHandler > ();
builder.Services.AddHttpClient("Public", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
builder.Services.AddApiAuthorization().AddAccountClaimsPrincipalFactory < RoleAccountClaimsPrincipalFactory > ();
builder.Services.AddScoped<IMyBlogApi, MyBlogApiClientSide>();
builder.Services.AddBlazoredSessionStorage(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});
builder.Services.AddScoped<IBrowserStorage, MyBlogBrowserStorage>();
builder.Services.AddSingleton<IBlogNotificationService, BlazorWebAssemblyBlogNotificationService>();

await builder.Build().RunAsync();
