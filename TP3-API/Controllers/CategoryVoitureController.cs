
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP3_API.Data;
using TP3_API.Model;

namespace TP3_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryVoitureController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoryVoitureController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: List all categories
        [HttpGet("ListCategories")]
        public async Task<IActionResult> ListCategories()
        {
            var categories = await _context.CategoriesVoitures.ToListAsync();

            return Ok(categories);
        }

        // GET: Get category by ID
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var categorie = await _context.CategoriesVoitures
                .FirstOrDefaultAsync(c => c.Id == id);

            if (categorie == null)
                return NotFound();

            return Ok(categorie);
        }

        // POST: Add a new category
        [HttpPost("Add")]
        public async Task<IActionResult> AddCategorie(CategoryVoiture categorie)
        {
            _context.CategoriesVoitures.Add(categorie);

            await _context.SaveChangesAsync();

            return Ok(categorie);
        }

        // PUT: Update a category
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateCategorie(int id, CategoryVoiture categorie)
        {
            var existingCategorie = await _context.CategoriesVoitures.FindAsync(id);

            if (existingCategorie == null)
                return NotFound();

            existingCategorie.Libelle = categorie.Libelle;
            existingCategorie.Description = categorie.Description;
            existingCategorie.ImageUrl = categorie.ImageUrl;

            await _context.SaveChangesAsync();

            return Ok(existingCategorie);
        }

        // DELETE: Delete a category
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteCategorie(int id)
        {
            var categorie = await _context.CategoriesVoitures.FindAsync(id);

            if (categorie == null)
                return NotFound();

            _context.CategoriesVoitures.Remove(categorie);

            await _context.SaveChangesAsync();

            return Ok(categorie);
        }
    }
}
