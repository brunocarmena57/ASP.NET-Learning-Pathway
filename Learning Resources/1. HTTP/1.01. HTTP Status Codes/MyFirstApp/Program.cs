// Create a new WebApplication builder with the provided command line arguments
var builder = WebApplication.CreateBuilder(args);

// Build the application and create an instance of the ASP.NET Core pipeline
var app = builder.Build();

// Set up a request handler that takes an HttpContext as input
app.Run(async (HttpContext context) =>
{
    // If a certain condition is true...
    if (1 == 1)
    {
        // Set the HTTP status code to 200 (OK)
        context.Response.StatusCode = 200;
    }
    // Otherwise...
    else
    {
        // Set the HTTP status code to 400 (Bad Request)
        context.Response.StatusCode = 400;
    }

    // Write "Hello" and "World" to the HTTP response stream
    await context.Response.WriteAsync("Hello");
    await context.Response.WriteAsync(" World");
});

// Start the application and begin listening for incoming requests
app.Run();
