
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP3_API.Data;
using TP3_API.Model;

namespace TP3_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoitureController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VoitureController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: List all cars
        [HttpGet("ListVoitures")]
        public async Task<IActionResult> ListVoitures()
        {
            var voitures = await _context.Voitures
                .Include(v => v.CategoryVoiture)
                .ToListAsync();

            return Ok(voitures);
        }

        // GET: Get car by ID
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var voiture = await _context.Voitures
                .Include(v => v.CategoryVoiture)
                .FirstOrDefaultAsync(v => v.Id == id);

            if (voiture == null)
                return NotFound();

            return Ok(voiture);
        }

        // POST: Add a new car
        [HttpPost("Add")]
        public async Task<IActionResult> AddVoiture(Voiture voiture)
        {
            var categorie = await _context.CategoriesVoitures
                .FindAsync(voiture.CategoryVoitureId);

            if (categorie == null)
                return BadRequest("Category does not exist.");

            _context.Voitures.Add(voiture);

            await _context.SaveChangesAsync();

            return Ok(voiture);
        }

        // PUT: Update a car
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateVoiture(int id, Voiture voiture)
        {
            var existingVoiture = await _context.Voitures.FindAsync(id);

            if (existingVoiture == null)
                return NotFound();

            var categorie = await _context.CategoriesVoitures
                .FindAsync(voiture.CategoryVoitureId);

            if (categorie == null)
                return BadRequest("Category does not exist.");

            existingVoiture.Marque = voiture.Marque;
            existingVoiture.Modele = voiture.Modele;
            existingVoiture.Matricule = voiture.Matricule;
            existingVoiture.Annee = voiture.Annee;
            existingVoiture.PrixJour = voiture.PrixJour;
            existingVoiture.EstDisponible = voiture.EstDisponible;
            existingVoiture.CategoryVoitureId = voiture.CategoryVoitureId;

            await _context.SaveChangesAsync();

            return Ok(existingVoiture);
        }

        // DELETE: Delete a car
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteVoiture(int id)
        {
            var voiture = await _context.Voitures.FindAsync(id);

            if (voiture == null)
                return NotFound();

            _context.Voitures.Remove(voiture);

            await _context.SaveChangesAsync();

            return Ok(voiture);
        }
    }
}
