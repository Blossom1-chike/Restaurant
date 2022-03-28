using Cakes.Data;
using Cakes.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cakes.Controllers
{
    [Route("api/Cake")]
    [ApiController]
    public class CakeController : ControllerBase
    {
        private readonly CakeDbContext _context;
        public CakeController(CakeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var cakes = await _context.Cakes.ToListAsync();
            return Ok(cakes);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCakeByIdAsync(int id)
        {
            var cake = await _context.Cakes.FindAsync(id);
            return Ok(cake);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Cake cake)
        {
            _context.Cakes.Add(cake);
            await _context.SaveChangesAsync();

            return Created($"/id?id={cake.Id}", cake);


        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Cake cakeToUpdate)
        {
            if (cakeToUpdate == null)
            {
                return NotFound();
            }
            _context.Cakes.Update(cakeToUpdate);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var cake = await _context.Cakes.FindAsync(id);
            if(cake == null)
            {
                return NotFound();
            }
            _context.Cakes.Remove(cake);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
