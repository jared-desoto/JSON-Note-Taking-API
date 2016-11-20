# JSON-Note-Taking-API
RESTful JSON note-taking api to post and get notes

Instructions to easily run server:
- Navigate to the NotesAPI folder
- Navigate to the bin folder
- Run the NotesAPI.exe file
- Now the API server is running on localhost:8080
(You can now send Post and Get commands to the server to create and retrieve notes using Curl, postman, or your favorite JSON interface)

Instructions to debug server:
- Requires Visual Studio (I used VS 2015 community)
- First install two required packages. 
    You can do this by navigating to the Package Manager Console 
    (View -> Other Windows -> Package Manager Console)
    Now type in these two commands into the console:
    "Install-Package Microsoft.AspNet.WebApi.OwinSelfHost"
    "Install-Package Newtonsoft.Json"
- Next open Notes API Solution File (NotesAPI.sln at the top directory)
- Verify that the Startup Project is specified as the APJISelfHostConsoleApp and then debug application
(You can now send Post and Get commands to the server to create and retrieve notes using Curl, postman, or your favorite JSON interface)
