using Microsoft.AspNetCore.Mvc;
using crm_backend.Models;  // the Models-Namespace, if models will be used 
using crm_backend.Data;    // my Data-Namespace, if I want to get data from DbContext 

namespace crm_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // creates a route like http://localhost:5252/api/customers.
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
            var customers = _context.Customers.ToList(); 
            return Ok(customers); // returns a list of customers 
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest(); 
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

            await _context.SaveChangesAsync(); //asp Framework method
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return NotFound();

            _context.Customers.Remove(customer); //remove is an asp.net method
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
