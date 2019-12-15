using System;
using System.Collections.Generic;

namespace BugFixerLibrary
{
    public class Utente
    {
        public string Login { get; set; }
        public string Name{ get; set; }
        public string Surname { get; set; }
        public DateTime BirthdTime { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public string odFiscale { get; set; }
    }

    public class Commento
    {
        public Utente User { get; set; }
        public DateTime CreationTime { get; set; }
        public string Text { get; set; }
    }

    public class Prodotto
    {
        public int Id { get; set; }
        public string CommercialName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Prodotto> DependenciesProdottos { get; set; }
        public virtual ICollection<Prodotto> IncompatibleProdottos { get; set; }
    }

    public class Segnalazione
    {
        enum stateEnum { Aperta, InCarico, Risolta }
        private Prodotto product;
        private Commento[] commentos;
        private Utente author;
        private stateEnum state;
        private DateTime creationTime;
        private string description;
        private string text;


    }

}
