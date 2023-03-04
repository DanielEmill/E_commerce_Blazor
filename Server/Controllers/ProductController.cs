using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Commerce.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
        private readonly DataContext _contexto;
        public ProductController(DataContext context)
        {
            _contexto = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct(){
            var products = await _contexto.Products.ToListAsync();
            return Ok(products);
        }
    }
}
