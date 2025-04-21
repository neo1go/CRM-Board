//Die gesamte Struktur des Kunden im Backend 
namespace crm_backend.Models
{
    public class Customer
    {
        public int Id { get; set; } // Primärschlüssel
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Priority { get; set; } // Für Sortierung im Frontend
    }
}
