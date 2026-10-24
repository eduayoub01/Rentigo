using Rentigo.Models;
using System.Collections.Generic;

namespace Rentigo.Repositories
{
    public interface IVoitureRepository
    {
        IEnumerable<Voiture> GetAll();
        Voiture? GetById(int id);
        IEnumerable<Voiture> GetByCategoryId(int categoryId);
        void Add(Voiture voiture);
        void Update(Voiture voiture);
        void Delete(int id);    
        bool Exists(int id);
    }
}