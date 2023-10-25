using API_Movie_Tunes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Movie_Tunes.Controllers
{
    public class TrilhaSonorasController : Controller
    {
        private readonly AppDbContext _context;

        public TrilhaSonorasController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.TrilhasSonoras.ToListAsync();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var model = await _context.TrilhasSonoras.FirstOrDefaultAsync(c => c.Id == id);

            if (model == null) return NotFound();
            GerarLinks(model);
            return Ok(model);
        }
        [HttpPost]
        public async Task<ActionResult> Create(TrilhasSonoras model)
        {
            _context.TrilhasSonoras.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = model.Id }, model);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, TrilhasSonoras model)
        {
            if (id != model.Id) return BadRequest();

            var modelDb = await _context.TrilhasSonoras.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);

            if (modelDb == null) return NotFound();
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Delete(int id, TrilhasSonoras model)
        {
            if (id != model.Id) return BadRequest();

            var modelDb = await _context.TrilhasSonoras.FindAsync(id);

            if (modelDb == null) return NotFound();
            _context.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private void GerarLinks(TrilhasSonoras model)
        {
            model.Links.Add(new LinkDto(model.Id, Url.ActionLink(), rel: "self", metodo: "GET"));
            model.Links.Add(new LinkDto(model.Id, Url.ActionLink(), rel: "update", metodo: "PUT"));
            model.Links.Add(new LinkDto(model.Id, Url.ActionLink(), rel: "delete", metodo: "Delete"));
        }
    }
}
