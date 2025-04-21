# CRM Board (Angular + .NET)

Dies ist ein einfaches CRM-System zur Verwaltung von Kunden und Notizen

## Technologien
- Angular (Frontend)
- ASP.NET Core Web API (Backend)
- MSSQL Server (Datenbank)

## Projektstruktur
- `/frontend/cmr-boar-ui` -Angular-Projekt
- `/backend/api` - .NET Web API
- `/documents` - Konzepte, Ideen, Diagramme

## Projektstand
- [x] Angular Struktur erstellt
- [] Login Seite ertellt
- [] Dashboard erstellt
- [] Kundenübersicht erstellt
- [] Backend-API erstellt

## Notizen
### 16.04.2025
- öffentliches git-repo erstellt 'CRM-Board'
- node installiert
- npm installiert
- angular-cli installiert
- Komponenten-Struktur Frontend erstellt 
### 21.04.2025
- Erstellungen der Kundenliste , vielleicht mit Prioritätenfunktion ?
- dazu Kundenattribute erstellt in models/customer.model.ts 
- Methoden zum Abrufen und Bearbeiten der Kunden in app/services/customer.services.ts erstellt
- customers.component.ts enthält nun alle Funktionen, um die Kunden zu bearbeiten.
- Extension, die eingebunden wurden: c# dev kit,NuGet Package Manager, :NET Install Tool, Sql Server (mssql),Swagger Viewer, Rest Client,
- Erstellung der Backendstruktur
- appsettings.json enthält die DB-Adresse
- Migration mit mssql durchgeführt
- Erstellung der DB mittels ORM / Migration in c#
- proxy.json hinzugefügt, um CORS-Probleme zu verhindern bei der angular Anfrage ans Backend
- Gesamte Backendstruktur hinzugefügt für Customer
- Prioritätenwertung für Kunden eingebaut.
- HttpCliebt muss bei standalone injiziert werden in app.component.ts
- Methoden Add,Delete,Update,Show hinzugefügt, sowohl im Frontend als auch im Backend