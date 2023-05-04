# Routing

In this section, I learned about routing in ASP.NET Core, which allows mapping incoming requests to controllers and actions based on the URL patterns. I learned about the following concepts:

<strong>Map:</strong> a method used to define a route for a specific URL pattern and HTTP method.

<strong>MapGet</strong> and <strong>MapPost:</strong> methods used to define a route for a GET or POST HTTP request.


<strong>Route parameters:</strong> placeholders in the URL pattern that capture values from the incoming request.


<strong>Default parameters:</strong> optional values for route parameters that can be used to simplify the URL pattern.


<strong>Custom route constraint class:</strong> a way to define custom logic to validate a route parameter.


<strong>Endpoint selection order:</strong> the order in which ASP.NET Core selects a matching endpoint for a given request.


<strong>WebRoot:</strong> the root directory of the web application, which is used to serve static files.


Here are some questions that you could find helpful:


### 1. What is Routing?

Routing is the process of determining how an incoming request is handled by the application. In ASP.NET Core, routing is responsible for matching incoming URLs to actions in the application.


### 2. How Routing works in ASP.NET Core?

In ASP.NET Core, routing works by matching incoming URLs to actions in the application based on predefined routing rules. These rules can be defined using either conventional routing or attribute routing. Once a matching action is found, it is executed and the result is returned to the client.


### 3. When will you prefer attribute routing over conventional routing?

Attribute routing is generally preferred when you have a small number of routes that are specific to a single controller or action. It is also useful when you need to define custom routes with constraints that cannot be expressed using conventional routing.


### 4. What are the important route constraints?

Route constraints are used to restrict the set of URLs that match a given route. Some of the important route constraints in ASP.NET Core include:

{int} - Matches an integer value.

{bool} - Matches a boolean value.

{alpha} - Matches alphabetic characters.

{datetime} - Matches a date and time value.


### 5. What is the purpose of the wwwroot folder?

The wwwroot folder is used to store static files such as CSS, JavaScript, and images that are served directly to clients without any processing from the server.


### 6. How do you change the path of wwwroot folder?

You can change the path of the wwwroot folder by modifying the WebHostBuilder in the Startup.cs file. Specifically, you can use the UseWebRoot method to specify a different directory for serving static files.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
By using routing in my ASP.NET Core applications, I can define clear and meaningful URLs for my users and map them to specific controller actions that handle the requests. I also learned how to use custom route constraints to validate route parameters and how to organize my static files in the WebRoot directory.
