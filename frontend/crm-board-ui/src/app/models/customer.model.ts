export interface Customer {
    id?: number; // optional falls vom Backend vergeben
    name: string;
    address: string;
    company: string;
    email: string;
    phoneNumber: string;
    priority: number; // bestimmt Sortierreihenfolge
  }
  