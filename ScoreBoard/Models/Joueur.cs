using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Joueur
    {
        [Required(ErrorMessage = "C'est requis")]
        public int Id { get; set; }

        [Required(ErrorMessage = "C'est requis")]
        [RegularExpression(@"^[a-zA-Z\s']{2,20}$",
            ErrorMessage = "Le nom ne doit comporter de caractères speciaux et avoir une lageur maximale de 20 caractères")]
        public string Nom { get; set; }

        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "C'est requis")]
        [RegularExpression(@"^[a-zA-Z\s']{2,20}$",
            ErrorMessage = "Le prenom ne doit comporter de caractères speciaux et avoir une lageur maximale de 20 caractères")]
        public string Prenom { get; set; }

        [Display(Name = "Équipe")]
        [RegularExpression(@"^[A-Z]{2,4}$", ErrorMessage = "L'équipe doit avoir de 2 à 4 lettres majuscules")]
        public string? Equipe { get; set; }

        [Display(Name = "Téléphone")]
        public string? Telephone { get; set; }

        [Required(ErrorMessage = "C'est requis")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|ca)$", ErrorMessage = "Le courriel doit avoir un identifiant et un client/serveur")]
        public string Courriel { get; set; }

        [Required(ErrorMessage = "C'est requis")]
        public List<Jeu>? Jeux { get; set; }
    }
}
