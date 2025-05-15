# CRM Board (Angular + .NET)

This is a small CRM-System to manage Customers and Notes

## Technologies
- Angular (Frontend)
- ASP.NET Core Web API (Backend)
- MSSQL Server (Datenbank)

## Project Structure
- `/frontend/cmr-boar-ui` -Angular-Projekt
- `/backend/api` - .NET Web API
- `/documents` - Konzepte, Ideen, Diagramme

## Project state
- [x] implemented angular structur 
- [] implemented Login Site 
- [] created Dashboard/Chart(s) 
- [] implemented customer overview
- [x] implemented Backend-API 

## Notes
### 16.04.2025
- created a pulbic git-repo, named 'CRM-Board'
- node installed
- npm installed
- angular-cli installed
- created component-structur for the frontend part 
### 21.04.2025
- Created a Customer List, maybe with Priority Number ?
- added Customerattributes in models/customer.model.ts 
- Methods to call and update the customer data in app/services/customer.services.ts (CRUD)
- customers.component.ts contains all neccesary components to show,alter,erase and/or create customer entries.
- installed extension in this project: c# dev kit,NuGet Package Manager, :NET Install Tool, Sql Server (mssql),Swagger Viewer, Rest Client,
- created the backendstructur
- appsettings.json contains the DB-Address
- executed migration with mssql. 
- Build the actual DB with ORM / migration in c#(asp.net)
- added proxy.json , to prevent CORS-Problems with angular requests to the backend
- Added the whole Customer backendstructur. 
- added a priority vote for customers.
- HttpCliebt has to be injected into app.component.ts, if project is a standalone-project.
- Added the CRUD Operations Add,Delete,Update,Show, in both frontend and backend.