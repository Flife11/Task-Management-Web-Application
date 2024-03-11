using Task_Mangement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task_Mangement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly SampleDBContext _context;
        public UserController(SampleDBContext context)
        {
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public ActionResult<IEnumerable<User>> Privacy()
        {
            //return View();
            return _context.User.ToList();
        }

        // GET: api/User/1
        [HttpGet("{id}")]
        public ActionResult<User> GetCustomer(int id)
        {
            var customer = _context.User.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        // POST: api/Customer
        [HttpPost]
        public ActionResult<User> CreateCustomer(User customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }
            _context.User.Add(customer);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCustomer), new { id = customer.UserId }, customer);
        }
    }
}
