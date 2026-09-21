using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreConsoleApp
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; } // Navigatieproperty
        public int PublishYear { get; set; }//Nieuw veld
    }
}