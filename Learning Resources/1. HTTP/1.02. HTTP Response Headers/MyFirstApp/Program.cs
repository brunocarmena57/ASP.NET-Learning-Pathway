// Create a new WebApplication builder with the provided command line arguments
var builder = WebApplication.CreateBuilder(args);

// Build the application and create an instance of the ASP.NET Core pipeline
var app = builder.Build();

// Set up a request handler that takes an HttpContext as input
app.Run(async (HttpContext context) =>
{
    // Set the value of the "MyKey" response header to "my value"
    context.Response.Headers["MyKey"] = "my value";

    // Set the value of the "Server" response header to "My server"
    context.Response.Headers["Server"] = "My server";

    // Set the value of the "Content-Type" response header to "text/html"
    context.Response.Headers["Content-Type"] = "text/html";

    // Write an HTML heading element containing the text "Hello" to the response stream
    await context.Response.WriteAsync("<h1>Hello</h1>");

    // Write an HTML heading element containing the text "World" to the response stream
    await context.Response.WriteAsync("<h2>World</h2>");
});

// Start the application and begin listening for incoming requests
app.Run();
