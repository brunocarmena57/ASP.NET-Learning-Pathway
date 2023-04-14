// Create a new WebApplication builder with the provided command line arguments
var builder = WebApplication.CreateBuilder(args);

// Build the application and create an instance of the ASP.NET Core pipeline
var app = builder.Build();

// Set up a request handler that takes an HttpContext as input
app.Run(async (HttpContext context) =>
{
    // Set the value of the "Content-type" response header to "text/html"
    context.Response.Headers["Content-type"] = "text/html";

    // If the incoming request's HTTP method is "GET"...
    if (context.Request.Method == "GET")
    {
        // Check if the request has a query parameter named "id"
        if (context.Request.Query.ContainsKey("id"))
        {
            // Get the value of the "id" query parameter
            string id = context.Request.Query["id"];

            // Write the value of the "id" query parameter to the response stream as a paragraph element
            await context.Response.WriteAsync($"<p>{id}</p>");
        }
    }
});

// Start the application and begin listening for incoming requests
app.Run();
