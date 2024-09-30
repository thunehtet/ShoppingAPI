using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping.Entities;

namespace Shopping.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductController(StoreContext storeContext) 
        {
            _context = storeContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get() 
        {
            return await _context.Products.ToListAsync();
           // return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            return await _context.Products.FindAsync(id);
        }
        
    }
}
