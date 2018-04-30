using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolaNaukowe.web.Extensions
{
    public static class CaseInsensitiveContainsExtension
    {
        public static bool Contains(this string source, string toCheck, StringComparison comparison)
        {
            return source?.IndexOf(toCheck, comparison) >= 0;
        }
    }
}
