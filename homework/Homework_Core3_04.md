# Linh Nguyen
## ASP.NET Core 3 Homework 04

1.What are the .NET SDK command line tools used for? Is their use required? Why or why not?

	For creating, managing, building, and running projects.
	If you are using Visual Studio Code, then the command line is the only
	option. Otherwise it is not necessary.

2.What kind of applications do the following templates create? Run these commands and read the
documentation. A brief summary of each template is sufficient.
dotnet new console --help
	A project for creating a command-line application that can run on .NET Core on Windows, Linux and macOS

dotnet new mvc --help
	An empty project template for creating an ASP.NET Core application. This template does not have any content in it. 
	(model view control)

dotnet new web --help
	A project template for creating an ASP.NET Core application with example ASP.NET Core MVC Views and Controllers. 
	This template can also be used for RESTful HTTP services.

3.What, specifically, do the following commands do?

dotnet new globaljson --sdk-version 3.1.101 --output MySolution/MyProject
	The first command creates a MySolution/MyProject folder that contains a global.json file, which specifies that the project
	will use .NET Core version 3.1.1.

dotnet new web --no-https --output MySolution/MyProject --framework netcoreapp3.1
	The second command creates the project using the web template

dotnet new sln -o MySolution
	Create a solution file that references the new project. Solution files are a convenient way of opening
	multiple related files at the same time. 

dotnet sln MySolution add MySolution/MyProject
	A MySolution.sln file is created in the MySolution folder

4.What is the purpose of the global.json file?

	Ensures the right version of the .NET Core SDK will be used by the project

5.What does the method app.UseStaticFiles() do?

	Adds support for responding to HTTP requests with static content in the wwwroot folder

6.What do the following two commands do?
dotnet build
	Will only build the project without actually running it.

dotnet run
	Building and Running the Project, automatically run dotnet build if necessary.

7.(not in book) You cah manage pacakges using the NuGet package manager and the command line tool
dotnet add package. What are packages and what are they used for.

	NuGet is a Package management system for Visual Studio.It makes it easy to add, update and remove external libraries in
	our application. Using NuGet, we can create our own packages easily and make it available for others.

8.What are tool packages and what are they used for?

	Install commands that can be used from the command line to perform operations on .NET Core projects. (One
	common example is the Entity Framework Core tools package that installs commands that are used to manage databases in ASP.)
	
9.What are client side packages and what are they used for?

	Contain content that is delivered to the client, such as images, CSS stylesheets, JavaScript files, and static
	HTML.(pg 63)

10.List two ways that a developer can debug code

	Use debuggers, or add System.Console.WriteLine statements to the code to figure out what is going on.