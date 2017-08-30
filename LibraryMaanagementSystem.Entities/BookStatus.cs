using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaanagementSystem.Entities
{
   public class BookStatus
    {
        public AvailabilityStatus AvailabilityStatus;

        public List<ErrorInformation> errors;
    }
}
