// Create a new WebApplication builder with the provided command line arguments
var builder = WebApplication.CreateBuilder(args);

// Build the application and create an instance of the ASP.NET Core pipeline
var app = builder.Build();

// Set up a request handler that takes an HttpContext as input
app.Run(async (HttpContext context) =>
{
    // Get the path of the current request
    string path = context.Request.Path;

    // Get the HTTP method of the current request
    string method = context.Request.Method;

    // Set the value of the "Content-type" response header to "text/html"
    context.Response.Headers["Content-type"] = "text/html";

    // Write the current request's path to the response stream as a paragraph element
    await context.Response.WriteAsync($"<p>{path}</p>");

    // Write the current request's HTTP method to the response stream as a paragraph element
    await context.Response.WriteAsync($"<p>{method}</p>");
});

// Start the application and begin listening for incoming requests
app.Run();
