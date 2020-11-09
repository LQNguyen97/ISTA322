# Linh Nguyen
## ASP.NET Core 3 Homework 03

1.What is the most important part of an ASP.NET Core 3 application?

	The data model is the most important part of any ASP.NET Core application. 

2.What is the domain model?

	The model is the representation of the real-world objects, processes, and rules that define the subject, 
	known as the domain, of the application.

3.Where are the model classes in an ASP.NET Core 3 application placed?

	Data model classes are defined in a folder named Models, Models Folder.

4.How many action methods can a controller class define?

	A single controller class can define multiple action methods. (As many as you need)

5.What is a tag helper?

	Is an instruction for Razor that will be performed when the view is rendered

6.What does the asp-action attribute do?

	Is an instruction to add an href attribute to the a element that contains a URL for an action method.

7.What is the difference between HTTP GET and HTTP POST? This is an important question, and you
should understand the difference.

	GET : responsible for displaying the initial blank form when someone first visits /Home/RsvpForm.
	POST:  responsible for receiving submitted data and deciding what to do with it.

8.What is model binding?

	Incoming data is parsed and the key/value pairs in the HTTP request are used to populate properties of domain model types
	uses to create parameter objects defined in controller action methods.
	Model Binding allows the program code access to the form values passed by the user to the web server.

9.Why should we validate user data? How do we validate user data?

	So that  users could not enter nonsense data or even submit an empty form.
	Validation rules are defined by applying attributes to model classes, which means the same
	validation rules can be applied in any form that uses that class.

10.What, specifically, is the ModelState.IsValid property?

	Provides details of the outcome of the model binding process. (Validate constraint)
	True: The model binder has been able to satisfy the validation constraints that was specified
	False: Validation errors.

11.What does the asp-validation-summary do?

	It displays a list of validation errors when the view is rendered.

12.Static content consists of content such as images, script files, style files, etc. In an ASP.NET Core
application, what is the name of the folder that cotains static content?

	wwwroot folder and organized by content type so that CSS stylesheets go into the wwwroot/css folder

13.What is Bootstrap? Who developed Bootstrap? Is Bootstrap a proprietary package? If not, what is
it?

	CSS framework originally developed by Twitter that has become a major open source project and a
	mainstay of web application development.