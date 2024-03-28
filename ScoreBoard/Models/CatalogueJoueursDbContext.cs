using Microsoft.EntityFrameworkCore;

namespace ScoreBoard.Models
{
    public class CatalogueJoueursDbContext : DbContext
    {
        public CatalogueJoueursDbContext(DbContextOptions<CatalogueJoueursDbContext> options) : base(options)
        {

        }
        public DbSet<Jeu> jeux { get; set; }

        public DbSet<Joueur> joueurs { get; set; }
    }
}
