using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMaanagementSystem.Entities
{
    public class Constants
    {
        public static class ErrorCode
        {
            public static readonly string InvalidBookRequired = "1000";
            public static readonly string Default = "500";
        }

        public static class ErrorMessage
        {
            public static readonly string InvalidOrder = "Invalid Book Requested For Issue";
        }
    }
}
