using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockKnock.Extensions
{
    public static class String
    {
        public static string Reverse(this string phrase)
        {
            string result = "";
            foreach(var character in phrase)
            {
                result = character + result;
            }
            return result;
        }
    }
}