using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Contracts
{
    public interface ILibraryManager<T>
    {
        void AddIssuedBook(T item);
        List<T> GetAllBooks();
        void RemoveIssuedBook(T item);

    }
}
