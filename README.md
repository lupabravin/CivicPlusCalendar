# Calendar App

**CivicPlus Interview Challenge**  
[.NET Core](https://dotnet.microsoft.com/download) Web Application that consumes an API to read and write events to a Calendar
## Features
- View all your events at homepage
- Add a new event via "Add Event" Tab
- Only works with the authorization token
- Field validations
- Services Unit Testing with [XUnit](https://xunit.net/)

## Installation with Docker

1. Install [Docker](https://docker.com) in your machine.
2. Clone the repository and go to the root folder
3. Open up your terminal and run the following command to build the containers: 
	```bash
	$ docker build -t aspnetapp .
	```
4. Run this next command to start:
	```bash
	$ docker run -d -p 5000:5000 --name civicplus-calendar-webapp aspnetapp
	```
5. The Calendar Application will be hosted on http://localhost:5000. You may access it with any browser.

## Default Installation
1.  Download and Install:
	 - [.NET 5 Build SDK](https://dotnet.microsoft.com/download/dotnet/5.0) 
	 - [.NET 5 Runtime](https://dotnet.microsoft.com/download/dotnet/5.0) 
2.  Open a terminal in the root folder and run the following commands to build the Calendar application:
	```
	$ dotnet restore
	$ dotnet build
	```
3.  Open another terminal in /CivicPlusCalendar folder an run the following command to run the Calendar Application:
	```
	$ dotnet run
	```
4.  The CalendarApplication will be hosted on http://localhost:5001. You may access it with any browser.
## Testing the Application
1. Go to the /CivicPlusCalendar.Tests folder
2. Open a terminal and run the following command:
```$ dotnet test```
## Usage

1. Go to the "Add Events" Tab
2. Fill the fields with the desired data
3. Click the "Submit" button
4. If you filled all the fields correctly, a success message should appear to you
5. Go back to the homepage and check your new event on the list
## Author
**Luís Paulo Bravin Pires**
- [Linkedin](https://www.linkedin.com/in/lu%C3%ADs-paulo-bravin-291348110/)
- [GitHub](https://github.com/lupabravin/)

## License
[Apache License 2.0](https://choosealicense.com/licenses/apache-2.0/)
