import { Component, inject, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { NavbarComponent } from './components/navbar/navbar.component';
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterModule, NavbarComponent],  // Hier die Komponenten importieren
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [HttpClient] 
})
export class AppComponent implements OnInit {
  title = 'crm-board-ui';
  customers$: Observable<any[]> | undefined;  // Observable für Kundenliste (hier mit undefined initialisiert)
  private http = inject(HttpClient);  // HttpClient injizieren

  ngOnInit(): void {
    // HTTP-Anfrage, die als Observable zurückgegeben wird
    this.customers$ = this.http.get<any[]>('https://localhost:5252/api/controller');//die Adresse zeigt aufs Backend
  }
}




//in dieser Datei wird alles importiert,was normalerweise in app.module importiert würde.