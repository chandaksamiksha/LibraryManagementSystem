using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaanagementSystem.Entities.Exceptions
{
    public class InvalidBookIssueRequestException : Exception
    {
            public InvalidBookIssueRequestException(string message) : base(message)
            {
            }
    }
}
