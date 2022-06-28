using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tidsreg_Api.DAL;
using Tidsreg_Api.Models;

namespace Tidsreg_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistreringsModelsController : ControllerBase
    {
        private readonly DBContext _context;

        public RegistreringsModelsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/RegistreringsModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RegistreringsModel>>> Getregistrering()
        {
            return await _context.registrering.ToListAsync();
        }

        // GET: api/RegistreringsModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RegistreringsModel>> GetRegistreringsModel(int id)
        {
            var registreringsModel = await _context.registrering.FindAsync(id);

            if (registreringsModel == null)
            {
                return NotFound();
            }

            return registreringsModel;
        }

        // PUT: api/RegistreringsModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegistreringsModel(int id, RegistreringsModel registreringsModel)
        {
            if (id != registreringsModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(registreringsModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistreringsModelExists(id))
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

        // POST: api/RegistreringsModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RegistreringsModel>> PostRegistreringsModel(RegistreringsModel registreringsModel)
        {
            _context.registrering.Add(registreringsModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRegistreringsModel", new { id = registreringsModel.Id }, registreringsModel);
        }

        // DELETE: api/RegistreringsModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegistreringsModel(int id)
        {
            var registreringsModel = await _context.registrering.FindAsync(id);
            if (registreringsModel == null)
            {
                return NotFound();
            }

            _context.registrering.Remove(registreringsModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RegistreringsModelExists(int id)
        {
            return _context.registrering.Any(e => e.Id == id);
        }
    }
}
