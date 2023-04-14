// Create a new instance of the WebApplicationBuilder using the command-line arguments.
var builder = WebApplication.CreateBuilder(args);

// Build the application and store the result in a variable called 'app'.
var app = builder.Build();

// Register a middleware to write "Hello" to the response.
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("Hello");
});

// Register another middleware to write "Hello again" to the response.
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("Hello again");
});

// Start the application by calling the final Run() method.
app.Run();


/* When this code runs, the first middleware component writes "Hello" to the response body, 
 * the second middleware component writes "Hello again", and then the program exits.
 Since each middleware component writes to the response body, 
we are able only to see "Hello again" in the response because it overwrites the previous middleware's response. */