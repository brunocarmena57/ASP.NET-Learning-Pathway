// Create a new WebApplication builder with the provided command line arguments
var builder = WebApplication.CreateBuilder(args);

// Build the application and create an instance of the ASP.NET Core pipeline
var app = builder.Build();

// Set up a request handler that takes an HttpContext as input
app.Run(async (HttpContext context) =>
{
    // Set the value of the "Content-type" response header to "text/html"
    context.Response.Headers["Content-type"] = "text/html";

    // Check if the incoming request contains a "User-Agent" header
    if (context.Request.Headers.ContainsKey("User-Agent"))
    {
        // Get the value of the "User-Agent" header
        string userAgent = context.Request.Headers["User-Agent"];

        // Write the value of the "User-Agent" header to the response stream as an HTML paragraph element
        await context.Response.WriteAsync($"<p>{userAgent}</p>");
    }
});

// Start the application and begin listening for incoming requests
app.Run();
