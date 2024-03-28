namespace ScoreBoard.Models
{
    public interface IJoueurRep
    {
        public IEnumerable<Joueur> ListeJoueurs { get; }

        public Joueur? GetJoueur(int joueurId);

        public void AddJoueur(Joueur joueur);

        public void RemoveJoueur(int joueurId);

        public void UpdateJoueur(Joueur joueur);  
    }
}
