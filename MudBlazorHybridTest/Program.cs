using Photino.Blazor;
using MudBlazorTest.Components;
using MudBlazor.Services;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        var builder = PhotinoBlazorAppBuilder.CreateDefault(args);
        builder.Services.AddMudServices();
        builder.Services.AddLogging();
        builder.RootComponents.Add<App>("app");

        var app = builder.Build();

        app.MainWindow
            .SetDevToolsEnabled(true)
            .SetSize(900, 600);

        app.Run();
    }
}