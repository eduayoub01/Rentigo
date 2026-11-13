
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP3_API.Model
{
    public class CategoryVoiture
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le libellé de la catégorie est obligatoire.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le libellé doit comporter entre 2 et 50 caractères.")]
        [Display(Name = "Libellé de la catégorie")]
        public string Libelle { get; set; } = string.Empty;

        [StringLength(250, ErrorMessage = "La description ne peut pas dépasser 250 caractères.")]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Display(Name = "URL de l'image")]
        public string? ImageUrl { get; set; }

        [NotMapped]
        [Display(Name = "Photo illustrative")]
        public IFormFile? ImageFile { get; set; }

        // Relation inverse : une catégorie regroupe plusieurs voitures
        [JsonIgnore]
        public ICollection<Voiture> Voitures { get; set; } = new List<Voiture>();
    }
}
