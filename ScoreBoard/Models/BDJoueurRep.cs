using Microsoft.EntityFrameworkCore;

namespace ScoreBoard.Models
{
    public class BDJoueurRep : IJoueurRep
    {
        private readonly CatalogueJoueursDbContext _catalogueJoueursDbContext;

        public BDJoueurRep(CatalogueJoueursDbContext catalogueJoueursDbContext)
        {
            _catalogueJoueursDbContext = catalogueJoueursDbContext;
        }

        public IEnumerable<Joueur> ListeJoueurs => _catalogueJoueursDbContext.joueurs.ToList();

        public void AddJoueur(Joueur joueur)
        {
            _catalogueJoueursDbContext.joueurs.Add(joueur);
            _catalogueJoueursDbContext.SaveChanges();
        }

        public Joueur GetJoueur(int joueurId)
        {
            return _catalogueJoueursDbContext.joueurs.Include(j => j.Jeux).FirstOrDefault(je => je.Id == joueurId);
        }

        public void RemoveJoueur(int joueurId)
        {
            _catalogueJoueursDbContext.joueurs.Remove(GetJoueur(joueurId));
            _catalogueJoueursDbContext.SaveChanges();
        }

        public void UpdateJoueur(Joueur joueur)
        {
            _catalogueJoueursDbContext.joueurs.Update(joueur);
            _catalogueJoueursDbContext.SaveChanges();
        }
    }
}
