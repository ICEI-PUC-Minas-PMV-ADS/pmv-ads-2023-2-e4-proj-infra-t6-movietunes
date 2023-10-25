using API_Movie_Tunes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Movie_Tunes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FilmesController(AppDbContext context)
        {
            _context = context; 
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Filmes.ToListAsync();
            return Ok(model);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var model = await _context.Filmes.Include(t => t.TrilhaSonoras).FirstOrDefaultAsync(c => c.Id == id);

            if (model == null) return NotFound();
            GerarLinks(model);
            return Ok(model);
        }
        [HttpPost]
        public async Task<ActionResult> Create(Filmes model)
        {
            _context.Filmes.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new {id = model.Id }, model);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Filmes model)
        {
            if (id != model.Id) return BadRequest();

            var modelDb = await _context.Filmes.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);

            if (modelDb == null) return NotFound();
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Delete(int id, Filmes model)
        {
            if (id != model.Id) return BadRequest();

            var modelDb = await _context.Filmes.FindAsync(id);

            if (modelDb == null) return NotFound();
            _context.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private void GerarLinks(Filmes model)
        {
            model.Links.Add(new LinkDto(model.Id, Url.ActionLink(), rel: "self", metodo: "GET"));
            model.Links.Add(new LinkDto(model.Id, Url.ActionLink(), rel: "update", metodo: "PUT"));
            model.Links.Add(new LinkDto(model.Id, Url.ActionLink(), rel: "delete", metodo: "Delete"));
        }
    }
}
