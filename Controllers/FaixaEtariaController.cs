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
    public class FaixaEtariaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FaixaEtariaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/FaixaEtaria
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FaixaEtaria>>> GetFaixaEtaria()
        {
            return await _context.Faixa_Etaria.ToListAsync();
        }

        // GET: api/FaixaEtaria/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FaixaEtaria>> GetFaixaEtaria(int id)
        {
            var faixaEtaria = await _context.Faixa_Etaria.FindAsync(id);

            if (faixaEtaria == null)
            {
                return NotFound();
            }

            return faixaEtaria;
        }

        // PUT: api/FaixaEtaria/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaixaEtaria(int id, FaixaEtaria faixaEtaria)
        {
            if (id != faixaEtaria.id)
            {
                return BadRequest();
            }

            _context.Entry(faixaEtaria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaixaEtariaExists(id))
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

        // POST: api/FaixaEtaria
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FaixaEtaria>> PostFaixaEtaria(FaixaEtaria faixaEtaria)
        {
            _context.Faixa_Etaria.Add(faixaEtaria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFaixaEtaria", new { id = faixaEtaria.id }, faixaEtaria);
        }

        // DELETE: api/FaixaEtaria/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FaixaEtaria>> DeleteFaixaEtaria(int id)
        {
            var faixaEtaria = await _context.Faixa_Etaria.FindAsync(id);
            if (faixaEtaria == null)
            {
                return NotFound();
            }

            _context.Faixa_Etaria.Remove(faixaEtaria);
            await _context.SaveChangesAsync();

            return faixaEtaria;
        }

        private bool FaixaEtariaExists(int id)
        {
            return _context.Faixa_Etaria.Any(e => e.id == id);
        }
    }
}
