using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevWeekPhilips;
using DevWeekPhilips.Data;

namespace DevWeekPhilips.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidenciaExameController : ControllerBase
    {
        private readonly AppDbContext _context;

        public IncidenciaExameController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/IncidenciaExame
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IncidenciaExame>>> GetIncidencia_Exame()
        {
            return await _context.Incidencia_Exame.ToListAsync();
           
        }

        // GET: api/IncidenciaExame/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IncidenciaExame>> GetIncidenciaExame(int id)
        {
            var incidenciaExame = await _context.Incidencia_Exame.FindAsync(id);

            if (incidenciaExame == null)
            {
                return NotFound();
            }

            return incidenciaExame;
        }

        // PUT: api/IncidenciaExame/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncidenciaExame(int id, IncidenciaExame incidenciaExame)
        {
            if (id != incidenciaExame.id)
            {
                return BadRequest();
            }

            _context.Entry(incidenciaExame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncidenciaExameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/IncidenciaExame
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<IncidenciaExame>> PostIncidenciaExame(IncidenciaExame incidenciaExame)
        {
            _context.Incidencia_Exame.Add(incidenciaExame);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIncidenciaExame", new { id = incidenciaExame.id }, incidenciaExame);
        }

        // DELETE: api/IncidenciaExame/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IncidenciaExame>> DeleteIncidenciaExame(int id)
        {
            var incidenciaExame = await _context.Incidencia_Exame.FindAsync(id);
            if (incidenciaExame == null)
            {
                return NotFound();
            }

            _context.Incidencia_Exame.Remove(incidenciaExame);
            await _context.SaveChangesAsync();

            return incidenciaExame;
        }

        private bool IncidenciaExameExists(int id)
        {
            return _context.Incidencia_Exame.Any(e => e.id == id);
        }
    }
}
