using BookstoreConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsoleApp
{
    internal class Boek
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int AuteurId { get; set; }
        public Auteur Auteur { get; set; } // Navigatieproperty
        public int PublishYear { get; set; }//Nieuw veld
    }
}
