# HTTP
Learning about HTTP
In this section, I started learning about HTTP, which stands for Hypertext Transfer Protocol. HTTP is the foundation of the World Wide Web and enables web browsers to communicate with web servers to retrieve and display web pages.
As I began exploring ASP.NET and web development, I quickly realized that understanding HTTP was essential for building effective and efficient web applications. I learned that when I enter a web address or URL into my browser's address bar, the browser sends an HTTP request to the web server hosting the website, asking it to provide the requested resource, such as an HTML file or an image. The web server then responds with an HTTP response, which includes the requested resource, along with any additional information, such as HTTP headers and status codes.

Here, are some main questions about HTTP, that's important to know the answers:

### 1. What is HTTP?

It is a protocol (rules) that must be followed to send things over the WWW. It is necessary to communicate between the client and the server.


### 2. What is the format of a Request Message?

A request message has 3 main parts:

Request line: Shows the method, url and http version.

Headers: Has information to give the server.

Body: Only if method is POST.


### 3. What are the important HTTP methods (or HTTP verbs) – (GET, POST, PUT, PATCH, HEAD, DELETE)?

GET: Request visualize data.

POST: Send data to the server.

PUT: To update/replace a record of a database.

PATCH: Partially update/replace a record of a database.

HEAD: Same as GET with no Body.

DELETE: To remove record of a database.


### 4. What are the important HTTP status codes?

An HTTP status code is a server response to a browser’s request. It indicates status of completed action as a response to the request.
HTTP status code classes:

1xx – Informational.

2xx – Success.

3xx – Redirection.

4xx – Client errors.

5xx – Server errors.


### 5. What is Content Negotiation in HTTP?

Mechanism to show different type of information based on what the user ca visualize (based on the user agent). E.g. getting a specific format that can be visualized.


### 6. Explain how HTTP protocol works?

Hypertext Transfer Protocol (HTTP) is an application-layer protocol for transmitting hypermedia documents, such as HTML. It handles communication between web browsers and web servers. HTTP follows a classical client-server model. A client, such as a web browser, opens a connection to make a request, then waits until it receives a response from the server.
HTTP is a protocol that allows the fetching of resources, such as HTML documents. It is the foundation of any data exchange on the Web, and it is a client-server protocol, which means requests are initiated by the recipient, usually the Web browser.


### 7. What is a web server?

The term web server can refer to both hardware and software, working separately or together.
On the hardware side, a web server is a computer with more processing power and memory that stores the application’s back-end code and static assets such as images and JavaScript, CSS, HTML files. This computer is connected to the internet and allows data flow between connected devices.
On the software side, a web server is a program that accepts HTTP requests from the clients, such as a web browser, processes the request, and returns a response. The response can be static, i.e. image/text, or dynamic, i.e. calculated total of the shopping cart.


By familiarizing myself with the basics of HTTP, I was able to better understand the role it plays in web development, and how it can be used in conjunction with ASP.NET to build powerful web applications. I encourage you to explore the resources included in this directory to learn more about HTTP and how it can be used in your own web development projects.
