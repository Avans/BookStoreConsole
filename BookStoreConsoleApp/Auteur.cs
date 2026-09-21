using BookstoreConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreConsoleApp
{
    internal class Auteur
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Boek> Boeken { get; set; } // Navigatieproperty
    }
}
