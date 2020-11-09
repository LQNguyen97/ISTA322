# Linh Nguyen
## ASP.NET Core 3 Homework 02

1.What is the difference between Visual Studio and Visual Studio Code?

	Visual Studio can be resource-hungry and slow, while Visual Studio Code is a light-weight alternative that is 
	perfectly capable of handling ASP.NET Core development.

2.What is LocalDB?

	It is a database component, which is a zero-configuration version of SQL Server.

3.What do these commands do?
	dotnet new globaljson --sdk-version 3.1.101 --output FirstProject
		(This command creates a folder named FirstProject and adds to it a file named global.json, which specifies the version
			of .NET Core that the project will use)
	dotnet new mvc --no-https --output FirstProject --framework netcoreapp3.1
		(This command creates a new ASP.NET Core project. The .NET Core SDK includes a range of templates for starting
			new projects)



4.What command do you use to build an ASP.NET project from the command line? What command
do you use to run the project?

	(dotnet build) build ASP.NET project
	(dotnet run) use to run the project

5.What is the purpose of an endpoint?

	Use to handle incoming requests. 

6.What is a controller?

	A controller determines what response to send back to a user when a user makes a browser request.
	Controller define what action should do.

7.Where are actions defined?

	In a controller. Each public method defined by a controller is an action. 
			(action is whatever you input/tell it to do.)

8.What is the purpose of the routing system?

	Responsible for selecting the endpoint that will handle an HTTP request

9.Assume that your ASP.NET application runs in a browser with a URL like http://localhost:5000.
List the three default routes configured by the ASP.NET Core routing system.

	/
	/Home              (Name of the CONTROLLER)
	/Home/Index        (name of the CONTROLLER/ACTION-METHOD)


10.What does the ViewResult object instruct ASP.NET Core to do?

	Instructing ASP.NET Core to render a view to the response. (View is a graphical interface where you 
																interact with your application)

11.How does ASP.NET Core know what View is to be called from an action method?

	By calling the View method, specifying the name of the view that I want to use. Look for view with the same name as the
	method.

12.What is the job of an action method?

	To construct data and pass it to the view so it can be used to create HTML content based on the data values
	Call the view.

13.What is a view model?

	The data provided to the view by using Action methods and passing arguments to the View method.

