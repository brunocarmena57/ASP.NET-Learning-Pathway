# Model Binding and Validations

In this section, I learned about model binding and validation in ASP.NET Core. Model binding is the process of mapping request data to action method parameters, while validation is the process of ensuring that the data is valid before processing it.

There are several sources of data that can be used for model binding, such as query string parameters, route data, and request body. ASP.NET Core also supports automatic model validation based on data annotations or custom validation attributes.

I learned about the different types of validation attributes, such as Required, Range, RegularExpression, and Compare. These attributes allow me to specify validation rules for model properties and ensure that the data meets certain criteria.

Additionally, I learned about how to implement custom model binders and custom validation attributes to handle more complex scenarios. This allows me to tailor the validation and binding process to the specific needs of my application.

Questions that i added:

### 1. What is model binding in ASP.NET CORE?

Model binding is the process of mapping data from an HTTP request to a model object in your application. In ASP.NET Core, it happens automatically when you pass parameters to an action method in a controller. The framework tries to match incoming data with the parameters and then populates them with the appropriate values. This allows you to work with strongly typed objects in your controllers, which can simplify your code and help catch errors early.


### 2. How validation works in ASP.NET CORE MVC and how they follow DRY principle?

In ASP.NET Core MVC, you can use data annotations or custom validators to perform input validation. Data annotations are attributes that you can add to properties in your model classes to specify validation rules, such as required fields, string length, or regular expressions. Custom validators are classes that you create to handle more complex validation scenarios, such as checking against a database or external API.



-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Overall, understanding model binding and validation is essential for building robust and secure ASP.NET Core applications. By leveraging the built-in validation attributes and creating custom ones when needed, I can ensure that my application is able to process and validate user input correctly.
