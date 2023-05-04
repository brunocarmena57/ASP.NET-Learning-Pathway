# Controllers & IActionResult

In the Controllers & IActionResult section, I learned about how controllers are the backbone of an ASP.NET Core application, responsible for handling requests and generating responses. I studied the different types of action results that can be returned by controllers, including ContentResult, JsonResult, FileResult, IActionResult, Status Code Results, and Redirect Results.

ContentResult allows you to return plain text or HTML content to the client, while JsonResult lets you return JSON data. FileResult can be used to return files to the client, such as images or PDFs. IActionResult is a base class for action results that provides a common interface for handling different types of results.

Status Code Results can be used to return HTTP status codes to the client, such as 200 OK or 404 Not Found. Redirect Results allow you to redirect the client to another URL.

I also learned about the various ways to configure routing for controllers, including convention-based routing and attribute routing. I explored the use of route parameters, default parameters, and custom route constraint classes, as well as the order of endpoint selection.

Some important questions:

### 1. What is Controller?

Controller is a class that is used to group-up a set of action methods.

Action methods do perform certain operation when a request is received & returns the IActionResult that can be sent as response to browser.

<strong>It performs the following tasks:</strong>

Reading requests such as receiving query string parameters, request body, request cookies, request headers etc.

Validation of the request details.

Invoking models (business logic)

Creating objects of ViewModel or DTO

Sending DTO objects to view (in case of view result)


<strong>The controller class should be either or both:</strong>

The class name should be suffixed with “Controller”. Eg: HomeController

The [Controller] attribute is applied to the same class or to its base class.


### 2. What is an Action Method?

An action method is a public method in a controller class that responds to a specific HTTP request. Each action method corresponds to a specific URL that a user can request. Action methods return an IActionResult or a specific derived type of IActionResult that represents the result of the action method.


### 3. Explain different types of Action Results in asp.net core

Controller is a class that is used to group-up a set of action methods.

<strong>IActionResult</strong>

Defines a contract that represents the result of an action method.

<strong>ActionResult</strong>

A default implementation of IActionResult.

<strong>ContentResult</strong>

Represents a text result.

<strong>EmptyResult</strong>

Represents an ActionResult that when executed will do nothing.

<strong>JsonResult</strong>

An action result which formats the given object as JSON.

<strong>PartialViewResult</strong>

Represents an ActionResult that renders a partial view to the response.

<strong>ViewResult</strong>

Represents an ActionResult that renders a view to the response.

<strong>ViewComponentResult</strong>

An IActionResult which renders a view component to the response.

<strong>StatusCodeResult</strong>

An IActionResult which sends a specific HTTP status code in response, without any response body.

<strong>UnauthorizedResult</strong>

An IActionResult which sends HTTP 401 status code in response, with / without any response body.

<strong>BadRequestResult</strong>

An IActionResult which sends HTTP 400 status code in response, with / without any response body.

<strong>NotFoundResult</strong>

An IActionResult which sends HTTP 404 status code in response, with / without any response body.

<strong>ObjectResult</strong>

An IActionResult which sends the data of the specified object in response body.

<strong>FileResult</strong>

An IActionResult which sends content of the specified file in response body.

<strong>RedirectToActionResult</strong>

An IActionResult which sends HTTP 301 or 302 status code in response to redirect the request to the specific action method.

<strong>LocalRedirectResult</strong>

An IActionResult which sends HTTP 301 or 302 status code in response to redirect the request to the specified local URL (within the same domain).

<strong>RedirectResult</strong>

An IActionResult which sends HTTP 301 or 302 status code in response to redirect the request to the specified local URL (within the same domain) or an external URL.


### 4. What's the HttpContext object? How can you access it within a Controller?

HttpContext encapsulates all HTTP-specific information about an individual HTTP request. You can access this object in controllers by using the ControllerBase.HttpContext property.

The HttpContext object has properties such as Items, Request, Response, Session, User etc.


---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
In conclusion, the Controllers & IActionResult section was a great learning experience for me. I learned about the different types of results that can be returned by an action method and how to handle them effectively. I also learned about the various ways to return data from a controller and how to redirect users to different parts of the application. Understanding the fundamentals of Controllers & IActionResult is essential for building any robust and scalable application in ASP.NET Core.
