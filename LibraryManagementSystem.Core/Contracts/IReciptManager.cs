using LibraryMaanagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Contracts
{
    public interface IReciptManager
    {
        Recipt GenerateRecipt(BookResponse bookResponse, BookRequestcs bookRequestcs);
    }
}
