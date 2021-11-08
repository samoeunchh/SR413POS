using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SR413POS.Data;
using System.Threading.Tasks;
using System.Linq;

namespace SR413POS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{code}")]
        public async Task<IActionResult> GetProduct(string code)
        {
            var data =await (from p in _context.Product
                        join pp in _context.ProductPrice on p.UnitId equals pp.UnitId
                        where p.Barcode.Equals(code)
                        select new
                        {
                            p.ProductId,
                            p.ProductName,
                            p.UnitId,
                            pp.Price,
                            p.Cost,
                            p.OnHand
                        }).FirstOrDefaultAsync();
            return Ok(data);
        }
    }
}
