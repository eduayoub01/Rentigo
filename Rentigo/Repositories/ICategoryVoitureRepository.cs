using Rentigo.Models;
using System.Collections.Generic;

namespace Rentigo.Repositories
{
    public interface ICategoryVoitureRepository
    {
        IEnumerable<CategoryVoiture> GetAll();
        CategoryVoiture? GetById(int id);
        void Add(CategoryVoiture category);
        void Update(CategoryVoiture category);
        void Delete(int id);
        bool Exists(int id);
    }
}
