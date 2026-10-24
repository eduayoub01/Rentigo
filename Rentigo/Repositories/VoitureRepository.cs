using Rentigo.Data;
using Rentigo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Rentigo.Repositories
{
    public class VoitureRepository : IVoitureRepository
    {
        private readonly ApplicationDbContext _context;

        public VoitureRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Voiture> GetAll()
        {
            // Include() charge la catégorie associée en effectuant une jointure SQL (JOIN)
            return _context.Voitures
                .Include(v => v.CategoryVoiture)
                .AsNoTracking()
                .ToList();
        }

        public Voiture? GetById(int id)
        {
            return _context.Voitures
                .Include(v => v.CategoryVoiture)
                .FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<Voiture> GetByCategoryId(int categoryId)
        {
            return _context.Voitures
                .Where(v => v.CategoryVoitureId == categoryId)
                .Include(v => v.CategoryVoiture)
                .AsNoTracking()
                .ToList();
        }

        public void Add(Voiture voiture)
        {
            _context.Voitures.Add(voiture);
            _context.SaveChanges();
        }

        public void Update(Voiture voiture)
        {
            _context.Voitures.Update(voiture);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var voiture = _context.Voitures.Find(id);
            if (voiture != null)
            {
                _context.Voitures.Remove(voiture);
                _context.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            return _context.Voitures.Any(v => v.Id == id);
        }
    }
}