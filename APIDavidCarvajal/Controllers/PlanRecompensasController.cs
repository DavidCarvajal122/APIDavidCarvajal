using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIDavidCarvajal.Data;
using APIDavidCarvajal.Models;

namespace APIDavidCarvajal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanRecompensasController : ControllerBase
    {
        private readonly APIDavidCarvajalContext _context;

        public PlanRecompensasController(APIDavidCarvajalContext context)
        {
            _context = context;
        }

        // GET: api/PlanRecompensas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanRecompensa>>> GetPlanRecompensa()
        {
            return await _context.PlanRecompensa.ToListAsync();
        }

        // GET: api/PlanRecompensas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlanRecompensa>> GetPlanRecompensa(int id)
        {
            var planRecompensa = await _context.PlanRecompensa.FindAsync(id);

            if (planRecompensa == null)
            {
                return NotFound();
            }

            return planRecompensa;
        }

        // PUT: api/PlanRecompensas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlanRecompensa(int id, PlanRecompensa planRecompensa)
        {
            if (id != planRecompensa.Id)
            {
                return BadRequest();
            }

            _context.Entry(planRecompensa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanRecompensaExists(id))
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

        // POST: api/PlanRecompensas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlanRecompensa>> PostPlanRecompensa(PlanRecompensa planRecompensa)
        {
            _context.PlanRecompensa.Add(planRecompensa);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlanRecompensa", new { id = planRecompensa.Id }, planRecompensa);
        }

        // DELETE: api/PlanRecompensas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlanRecompensa(int id)
        {
            var planRecompensa = await _context.PlanRecompensa.FindAsync(id);
            if (planRecompensa == null)
            {
                return NotFound();
            }

            _context.PlanRecompensa.Remove(planRecompensa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlanRecompensaExists(int id)
        {
            return _context.PlanRecompensa.Any(e => e.Id == id);
        }
    }
}
