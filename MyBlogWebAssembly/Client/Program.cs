using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyBlogWebAssembly.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using MyBlogWebAssembly.Client.Authentication;
using MyBlog.Data.Interfaces;
using MyBlog.Data;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("Authenticated", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)).AddHttpMessageHandler < BaseAddressAuthorizationMessageHandler > ();
builder.Services.AddHttpClient("Public", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
builder.Services.AddApiAuthorization().AddAccountClaimsPrincipalFactory < RoleAccountClaimsPrincipalFactory > ();
builder.Services.AddScoped<IMyBlogApi, MyBlogApiClientSide>();

await builder.Build().RunAsync();
