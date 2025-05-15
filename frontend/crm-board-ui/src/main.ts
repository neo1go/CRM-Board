import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { provideHttpClient } from '@angular/common/http';  // <-- for registering any HttpClients
import { provideRouter } from '@angular/router';          // <-- imports the router (the router is used to navigate between all pages of the project)
import { routes } from './app/app.routes';                 // <-- my Routes

bootstrapApplication(AppComponent, {
  providers: [
    provideHttpClient(),                                // <-- provide HttpClient 
    provideRouter(routes),                               // <-- provide Router 
  ]
}).catch(err => console.error(err));
