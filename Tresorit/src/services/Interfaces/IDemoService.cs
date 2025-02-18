namespace Tresorit.Services.Interfaces;

public interface IDemoService
{
    Task RunAsync(Func<string, Task> writeOutputAync);

    string GetEndpoint();
}