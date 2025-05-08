import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { provideHttpClient } from '@angular/common/http';  // <-- Zum Registrieren des HttpClients
import { provideRouter } from '@angular/router';          // <-- Zum Bereitstellen des Routers
import { routes } from './app/app.routes';                 // <-- Deine Routen

bootstrapApplication(AppComponent, {
  providers: [
    provideHttpClient(),                                // <-- HttpClient bereitstellen
    provideRouter(routes),                               // <-- Router bereitstellen
  ]
}).catch(err => console.error(err));
