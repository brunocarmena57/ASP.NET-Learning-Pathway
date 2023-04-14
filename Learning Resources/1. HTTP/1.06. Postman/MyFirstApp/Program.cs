// Create a new WebApplication builder with the provided command line arguments
var builder = WebApplication.CreateBuilder(args);

// Build the application and create an instance of the ASP.NET Core pipeline
var app = builder.Build();

// Set up a request handler that takes an HttpContext as input
app.Run(async (HttpContext context) =>
{
    // Set the value of the "Content-type" response header to "text/html"
    context.Response.Headers["Content-type"] = "text/html";

    // Check if the incoming request contains an "AuthorizationKey" header
    if (context.Request.Headers.ContainsKey("AuthorizationKey"))
    {
        // Get the value of the "AuthorizationKey" header
        string auth = context.Request.Headers["AuthorizationKey"];

        // Write the value of the "AuthorizationKey" header to the response stream as an HTML paragraph element
        await context.Response.WriteAsync($"<p>{auth}</p>");
    }
});

// Start the application and begin listening for incoming requests
app.Run();
