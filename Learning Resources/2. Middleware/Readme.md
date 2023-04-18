# MIDDLEWARE

In this section, I approached in middleware and learned about its importance in the application pipeline. I started by studying the concept of the middleware chain and how each piece of middleware in the pipeline contributes to the application's overall functionality. Next, I explored how to create custom middleware classes and extensions, which allowed me to add custom functionality to my application's pipeline. I also learned about conventional middleware classes and the use of the UseWhen method to conditionally apply middleware based on specific conditions. Throughout this section, I gained a deeper understanding of middleware and its role in ASP.NET development.

Here are some important questions: 


### 1. What is middleware?
It is the code that is injected into the application pipeline to handle requests and responses. They are just like chained to each other and form as a pipeline. The incoming requests are passed through this pipeline where all middleware is configured, and middleware can perform some action on the request before passing it to the next middleware. Same as for the responses, they are also passing through the middleware but in reverse order.


### 2. What is the difference between IApplicationBuilder.Use() and IApplicationBuilder.Run()?
IApplicationBuilder.Use() and IApplicationBuilder.Run() are both methods used to add middleware to the ASP.NET Core pipeline. The main difference is that Use() method can be used to add middleware that can execute and then call the next middleware in the pipeline. Whereas, Run() method is used to add middleware that can execute and does not call the next middleware in the pipeline.


### 3. What is the use of the "Map" extension while adding middleware to the ASP.NET Core pipeline?
The Map extension method is used to add middleware conditionally based on the request path or URL. For example, you can use Map("/api", app => app.UseApiMiddleware()) to add middleware only for requests that match the "/api" URL prefix.


### 4. How do you create a custom middleware?
To create a custom middleware, you need to create a class that has a constructor accepting a RequestDelegate parameter, which represents the next middleware in the pipeline. You can then add your custom logic to the InvokeAsync method, which is called when the middleware is executed. Finally, you can use the Use() or Run() method to add your custom middleware to the pipeline.


### 5. What is the right order of middleware used in production-level applications?
The order of middleware in a production-level application depends on the specific needs of the application. Generally, the middleware that handles request processing should be placed earlier in the pipeline, followed by middleware for error handling, logging, and authentication. However, the order can vary depending on the requirements of the application. It is essential to test the application thoroughly to ensure that the middleware is executing in the expected order.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
In this chapter, i was able to better understand the role of middleware in the request-response pipeline and how it can be used to perform various tasks such as authentication, routing, logging, and error handling. Understanding middleware concepts is crucial in developing efficient and effective web applications, and can greatly enhance your skills as a web developer.
