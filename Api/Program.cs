var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    message = "Hello from Cloud Build!",
    version = typeof(Program).Assembly.GetName().Version?.ToString() ?? "1.0.0",
    commit = Environment.GetEnvironmentVariable("COMMIT_SHA") ?? "local"
});

app.MapGet("/healthz", () => "ok");

app.Run();

// pentru Microsoft.AspNetCore.Mvc.Testing
public partial class Program { }

