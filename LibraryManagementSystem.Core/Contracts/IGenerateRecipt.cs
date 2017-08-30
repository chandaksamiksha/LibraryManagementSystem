using LibraryMaanagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Core.Contracts
{
    public interface IGenerateRecipt
    {
       Recipt CreateRecipt(Book book,Member member);
    }
}
