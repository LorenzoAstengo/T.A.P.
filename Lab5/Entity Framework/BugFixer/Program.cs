using System;
using System.Data.Entity;
using BugFixerLibrary;

namespace BugFixer
{
    public class BugFixer : DbContext
    {
        public DbSet<Utente> User { get; set; }
        public DbSet<Commento> Comments { get; set; }
        public DbSet<Prodotto> Products { get; set; }
        public DbSet<Segnalazione> Reports { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
