using MiddlewareExample.CustomMiddleware; // Importing custom middleware

// Create builder instance
var builder = WebApplication.CreateBuilder(args);

// Add custom middleware service to builder
builder.Services.AddTransient<MyCustomMiddleware>();

// Build the app instance
var app = builder.Build();

// Middlware 1
// This middleware writes "From Midleware 1" to the response and passes control to the next middleware in the pipeline
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("From Midleware 1\n");
    await next(context);
});

// Middleware 2
// This middleware uses the custom middleware "MyCustomMiddleware" to process the request
app.UseMyCustomMiddleware();

// Middleware 3
// This middleware writes "From Middleware 3" to the response
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("From Middleware 3\n");
});

// Run the app
app.Run();
