using Azure.Data.Tables;
using Azure.Identity;
using Microsoft.Extensions.Options;
using Tresorit.Services;
using Tresorit.Services.Interfaces;
using Tresorit.Web.Components;

using Settings = Tresorit.Models.Settings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddOptions<Settings.Configuration>().Bind(builder.Configuration.GetSection(nameof(Settings.Configuration)));

builder.Services.AddSingleton<TableServiceClient>((serviceProvider) =>
{
    IOptions<Settings.Configuration> configurationOptions = serviceProvider.GetRequiredService<IOptions<Settings.Configuration>>();
    Settings.Configuration configuration = configurationOptions.Value;

    // <create_client>
    TableServiceClient client = new(
        endpoint: new Uri(configuration.AzureCosmosDB.Endpoint),
        tokenCredential: new DefaultAzureCredential()
    );
    // </create_client>
    return client;
});

builder.Services.AddTransient<IDemoService, DemoService>();

var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

app.Run();
