using Core.Entities;
using ECommerce.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly storeContext _context;
        public ProductController(storeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Product>> GetProducts()
        {
            var data = await _context.Products.ToListAsync();
            return data;
        }
        [HttpGet("{id}")]
        public async Task<Product> GetProduct(int id)
        {
            var data=await _context.Products.FindAsync(id);
            return data;
        }
    }
}
