using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rentigo.Models;
using Rentigo.Repositories;

namespace Rentigo.Controllers
{
    public class VoitureController : Controller
    {
        private readonly IVoitureRepository _voitureRepo;
        private readonly ICategoryVoitureRepository _categoryRepo;

        public VoitureController(IVoitureRepository voitureRepo, ICategoryVoitureRepository categoryRepo)
        {
            _voitureRepo = voitureRepo;
            _categoryRepo = categoryRepo;
        }

        /// <summary>
        /// Méthode utilitaire privée : alimente le ViewBag avec la liste des catégories pour le <select>
        /// </summary>
        private void PopulateCategoriesDropDownList(object? selectedCategory = null)
        {
            var categories = _categoryRepo.GetAll();
            ViewBag.Categories = new SelectList(categories, "Id", "Libelle", selectedCategory);
        }

        // =========================================================================
        // 1. LISTE DE TOUTES LES VOITURES (READ)
        // =========================================================================
        public IActionResult Index()
        {
            var voitures = _voitureRepo.GetAll();
            return View(voitures);
        }

        // =========================================================================
        // 2. DÉTAILS D'UN VÉHICULE
        // =========================================================================
        public IActionResult Details(int id)
        {
            var voiture = _voitureRepo.GetById(id);
            if (voiture == null)
            {
                return NotFound();
            }
            return View(voiture);
        }

        // =========================================================================
        // 3. CRÉATION (CREATE) - GET & POST
        // =========================================================================
        [HttpGet]
        public IActionResult Create()
        {
            PopulateCategoriesDropDownList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Voiture voiture)
        {
            if (ModelState.IsValid)
            {
                _voitureRepo.Add(voiture);
                TempData["SuccessMessage"] = $"Le véhicule {voiture.Marque} {voiture.Modele} a été ajouté avec succès !";
                return RedirectToAction(nameof(Index));
            }

            // En cas d'erreur de saisie, recharger la liste des catégories
            PopulateCategoriesDropDownList(voiture.CategoryVoitureId);
            return View(voiture);
        }

        // =========================================================================
        // 4. MODIFICATION (EDIT) - GET & POST
        // =========================================================================
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var voiture = _voitureRepo.GetById(id);
            if (voiture == null)
            {
                return NotFound();
            }

            PopulateCategoriesDropDownList(voiture.CategoryVoitureId);
            return View(voiture);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Voiture voiture)
        {
            if (id != voiture.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _voitureRepo.Update(voiture);
                TempData["SuccessMessage"] = $"Le véhicule {voiture.Marque} {voiture.Modele} a été mis à jour avec succès !";
                return RedirectToAction(nameof(Index));
            }

            PopulateCategoriesDropDownList(voiture.CategoryVoitureId);
            return View(voiture);
        }

        // =========================================================================
        // 5. SUPPRESSION (DELETE) - GET & POST
        // =========================================================================
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var voiture = _voitureRepo.GetById(id);
            if (voiture == null)
            {
                return NotFound();
            }
            return View(voiture);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var voiture = _voitureRepo.GetById(id);
            if (voiture != null)
            {
                _voitureRepo.Delete(id);
                TempData["SuccessMessage"] = $"Le véhicule {voiture.Marque} {voiture.Modele} ({voiture.Matricule}) a été supprimé.";
            }

            return RedirectToAction(nameof(Index));
        }
    }
}