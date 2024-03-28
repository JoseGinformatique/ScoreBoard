using System.ComponentModel.DataAnnotations;

namespace ScoreBoard.Models
{
    public class Jeu
    {
        [Required(ErrorMessage = "C'est requis")]
        public int Id { get; set; }

        [Required(ErrorMessage = "C'est requis")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "C'est requis")]
        [DataType("Date")]
        public DateTime DateSortie { get; set; }

        [Required(ErrorMessage = "C'est requis")]
        public string Description { get; set; }

        [Display(Name = "Identifiant du joueur")]
        [Required(ErrorMessage = "C'est requis")]
        public int JoueurId { get; set; }

        [Required(ErrorMessage = "C'est requis")]
        public Joueur Joueur { get; set; }

        [Display(Name = "Score du joueur")]
        [Required(ErrorMessage = "C'est requis")]
        [Range(0,100, ErrorMessage = "Le score du jouer doit être entre 0 et 100")]
        public int ScoreJoueur { get; set; }

        [Display(Name = "Date d'enregistrement")]
        [Required(ErrorMessage = "C'est requis")]
        [DataType("Date")]
        public DateTime DateEnregistrement { get; set; }
    }
}
