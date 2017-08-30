using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaanagementSystem.Entities
{
    public class Book
    {
        public string Name { get; private set; }
        public Genere Genere { get; private set; }
        public string AuthorName { get; }
        public double BookId { get; private set; }
        public AvailabilityStatus AvailabilityStatus { get; private set; }
        public double Price { get; private set; }

        public Book(string name, Genere genere, string authorName, double bookId, AvailabilityStatus status, double price)
        {
            Name = name;
            Genere = genere;
            AuthorName = authorName;
            BookId = bookId;
            AvailabilityStatus = status;
            Price = price;

        }
    }
}
