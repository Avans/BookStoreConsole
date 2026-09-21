using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreConsoleApp
{
    public class BookstoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Let op: Gebruik hier een passende connection string voor jouw omgeving.
            // (localdb)\mssqllocaldb is standaard aanwezig met Visual Studio.
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database = BookstoreDb; Trusted_Connection = True; ");
        }
    }
}
