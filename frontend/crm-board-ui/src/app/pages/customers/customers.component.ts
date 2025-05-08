import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerService } from '../../services/customer.service';
import { Customer } from '../../models/customer.model';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-customers',
  standalone: true,
  imports: [CommonModule, RouterModule, FormsModule],
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent {
  customers: Customer[] = [];
  errorMessage: string = '';
  isAllCustomersVisible: boolean = false;  // Flag für die Anzeige der gesamten Kunden
  newCustomer: Customer = {  // Neues Kundenobjekt für das Formular
    id: 0,
    name: '',
    address: '',
    company: '',
    email: '',
    phoneNumber: '',
    priority: 3
  };

  constructor(private customerService: CustomerService) { }

  ngOnInit(): void {
    this.loadCustomers();
  }

  // Alle Kunden anzeigen
  showAllCustomers(): void {
    this.customerService.getCustomers().subscribe({
      next: (data) => {
        this.customers = data.sort((a, b) => a.priority - b.priority);  // Sortieren nach Priorität
        this.isAllCustomersVisible = true;  // Kunden sichtbar machen
      },
      error: (err) => {
        this.errorMessage = 'Fehler beim Laden der Kunden: ' + err.message;
        console.error(this.errorMessage);
      }
    });
  }

  // Kunden hinzufügen
  addCustomer(): void {
    this.customerService.addCustomer(this.newCustomer).subscribe({
      next: (addedCustomer) => {
        this.customers.push(addedCustomer);  // Füge den neuen Kunden zur Liste hinzu
        this.newCustomer = {  // Formular zurücksetzen
          id: 0,
          name: '',
          address: '',
          company: '',
          email: '',
          phoneNumber: '',
          priority: 3
        };
      },
      error: (err) => {
        this.errorMessage = 'Fehler beim Hinzufügen des Kunden: ' + err.message;
        console.error(this.errorMessage);
      }
    });
  }

  // Methode zum Laden der Kunden
  loadCustomers(): void {
    this.customerService.getCustomers().subscribe({
      next: (data) => {
        this.customers = data.sort((a, b) => a.priority - b.priority); // Kunden nach Priorität sortieren
      },
      error: (err) => {
        this.errorMessage = 'Fehler beim Laden der Kunden: ' + err.message;
        console.error(this.errorMessage);
      }
    });
  }

  // Kunden aktualisieren
  updateCustomer(id: number, updatedCustomer: Customer): void {
    this.customerService.updateCustomer(id, updatedCustomer).subscribe({
      next: () => this.loadCustomers(),
      error: (err) => {
        this.errorMessage = 'Fehler beim Aktualisieren des Kunden: ' + err.message;
        console.error(this.errorMessage);
      }
    });
  }

  // Kunden löschen
  deleteCustomer(id: number): void {
    this.customerService.deleteCustomer(id).subscribe({
      next: () => this.loadCustomers(),
      error: (err) => {
        this.errorMessage = 'Fehler beim Löschen des Kunden: ' + err.message;
        console.error(this.errorMessage);
      }
    })
  }
};
