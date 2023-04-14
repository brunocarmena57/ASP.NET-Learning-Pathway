// Import the necessary namespaces
using Microsoft.Extensions.Primitives;
using System.IO;

// Create a new WebApplication builder with the provided command line arguments
var builder = WebApplication.CreateBuilder(args);

// Build the application and create an instance of the ASP.NET Core pipeline
var app = builder.Build();

// Set up a request handler that takes an HttpContext as input
app.Run(async (HttpContext context) =>
{
    // Create a new StreamReader object to read the request body
    StreamReader reader = new StreamReader(context.Request.Body);

    // Read the entire request body and store it in a string variable
    string body = await reader.ReadToEndAsync();

    // Parse the request body into a dictionary of key-value pairs
    Dictionary<string, StringValues> queryDict = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(body);

    // Check if the parsed dictionary contains a key called "firstName"
    if (queryDict.ContainsKey("firstName"))
    {
        // Get the value of the "firstName" key from the dictionary
        string firstName = queryDict["firstName"][0];

        // Write the value of the "firstName" key to the response stream
        await context.Response.WriteAsync(firstName);
    }
});

// Start the application and begin listening for incoming requests
app.Run();
