using Microsoft.AspNetCore.Mvc;
using crm_backend.Models;  // Dein Models-Namespace, falls du Modelle verwendest
using crm_backend.Data;    // Dein Data-Namespace, wenn du auf den DbContext zugreifst

namespace crm_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // Dies erstellt eine Route wie http://localhost:5252/api/customers. Dies ist quasi die Kurzschreibweise
    public class CustomersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = _context.Customers.ToList(); // Hier gehst du davon aus, dass du ein "Customers"-DbSet im DbContext hast
            return Ok(customers); // Gibt die Liste der Kunden zurück
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();  //bricht bei leeren Daten sofort ab.
            }

            _context.Customers.Add(customer);

            await _context.SaveChangesAsync();

            return Ok(customer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, [FromBody] Customer updatedCustomer)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return NotFound();

            // Update-Felder einzeln übertragen
            customer.Name = updatedCustomer.Name;
            customer.Address = updatedCustomer.Address;
            customer.Company = updatedCustomer.Company;
            customer.Email = updatedCustomer.Email;
            customer.PhoneNumber = updatedCustomer.PhoneNumber;
            customer.Priority = updatedCustomer.Priority;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return NotFound();

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
