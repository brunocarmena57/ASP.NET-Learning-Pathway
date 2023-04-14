// Create builder and build application
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// UseWhen middleware to branch middleware pipeline based on query parameter
app.UseWhen(
    context => context.Request.Query.ContainsKey("username"),
    app => {
        // Middleware branch for requests with "username" query parameter
        app.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("Hello from Middleware branch");
            await next();
        });
    });

// Main middleware pipeline
app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from middleware at main chain");
});

// Start the application
app.Run();
