using BookstoreConsoleApp;
using Microsoft.EntityFrameworkCore;

namespace BookStoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //============================================================================================
            //Connected scenario in een niet Web situatie.
            //EF doet auto tracking zolang het binnen dezelfde contextDb instantie valt
            //=============================================================================================
            var ctx = new BookstoreDbContext();


            var author1 = new Author { Name = "Joop" };
            var author2 = new Author { Name = "Sandra" };
            ctx.Authors.Add(author1);
            ctx.Authors.Add(author2);
            ctx.SaveChanges();


            //var book1 = new Book { Title = "titel1", PublishYear = 1978, Author = author1 };
            //var book2 = new Book { Title = "titel2", PublishYear = 2026, Author = author2 };
            //var book3 = new Book { Title = "titel3", PublishYear = 2025, Author = author2 };

            //ctx.Books.AddRange(book1, book2, book3);
            //ctx.SaveChanges();


            //var books = ctx.Books.Include(a => a.Author).Where(b => b.Author.Name == "sandra").ToList();
            //Where(b => b.Author.Name == "sandra");
            //foreach(var b in books)
            //{
            //    Console.WriteLine($"{b.Title} en auteur is: {b.Author.Name}");
            //}

            //books.ForEach(b => Console.WriteLine($"{b.Title} en auteur is: {b.Author.Name}"));

            //============================================================================================
            //Connected scenario in een niet Web situatie.
            //EF doet auto tracking zolang het binnen dezelfde contextDb instantie valt
            //=============================================================================================




            //============================================================================================
            //Disconnected scenario in een Web situatie.
            //EF kan GEEN auto tracking plaatsvinden wanneer de context instanties telkens na een request worden vernietigd.
            //=============================================================================================


            //Beheerder Voegt een product toe vanuit een admin site.


            //var author1 =  new Author { Name = "Jan" };
            //var book = new Book { Title = "Sudoku", PublishYear = 2020, Author = author1 };


            ////TOEVOEGEN POST request
            //using (var ctx = new BookstoreDbContext())
            //{
            //    ctx.Books.Add(book);
            //    ctx.SaveChanges();
            //}


            //Een paar dagen later vraagt de beheerder het boek op want er is een fout gemaakt
            //OPHALEN GET Request

            //Book? bookFromServer = null;

            //using (var ctx = new BookstoreDbContext())
            //{
            //    bookFromServer = ctx.Books.AsNoTracking().FirstOrDefault(b => b.PublishYear == 2023);
            //}

            //De beheerder krijgt de gegevens in de browser
            //Console.WriteLine(bookFromServer.Title);


            //Vervolgens veranderd hij de fout en stuurt het weer naar de server PATCH request
            //Ditmaal moet er een update plaatsvinden

            //bookFromServer.Title = "Mozaïken";


            //We gebruiken een Patch request want we updaten maar 1 property van het Book object
            //Het request komt aan op de server en instantieren een nieuwe context

            
            //using (var ctx = new BookstoreDbContext())
            //{
            //    ctx.Books.Entry(bookFromServer)
            //        .Property(b => b.Title)
            //        .IsModified = true;

            //    ctx.SaveChanges();
            //}

           
            
            //Met RemoveRange kunnen we meerdere records uit de database verwijderen
            //using (var ctx = new BookstoreDbContext())
            //{
            //    var ls = new List<Author>
            //    {
            //        new Author(){Id=4},
            //        new Author(){Id=5},
            //        new Author(){Id=6}
            //    };
            //    ctx.Authors.RemoveRange(ls);
            //    ctx.SaveChanges();
            //};
        } 
     }
}
