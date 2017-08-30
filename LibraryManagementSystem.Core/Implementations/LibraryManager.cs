using LibraryMaanagementSystem.Entities;
using LibraryManagementSystem.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Implementations
{
    public class LibraryManager: ILibraryManager
    {
        private List<Book> _book = new List<Book>();
        private AvailabilityStatus _status;

        public void IssueABook(Book book)
        {
            bool status=IsBookIssued(book);
            if (status)
            {
                _book.Add(book);
                RemoveIssuedBook(book);
            }
            else
            {
               //Error
            }

        }

        public List<Book> GetIssuedBookDetails()
        {
            return _book;
        }

        public bool IsBookIssued(Book book)
        {
            if(_status==AvailabilityStatus.NotAvaliable)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void RemoveIssuedBook(Book book)
        {
            _book.Remove(book);
        }

    }
}
