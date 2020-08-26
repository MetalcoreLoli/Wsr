using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shindows.Core
{
    public static class StringHelper
    {
        public static string IfNullThrowException(this string str)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                throw new System.Exception("String must be not null or empty !!!");
            return str;
        }
    }
}
