using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CluedIn.Vocabulariess.CDM.CLI
{
    public static class StringExtension
    {
        public static string SplitCamelCase(this string str)
        {
            return Regex.Replace(Regex.Replace(str, @"(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), @"(\p{Ll})(\P{Ll})", "$1 $2").CamelCase();
        }
        public static string CamelCase(this string str)
        {
            return char.ToUpper(str[0]) + str[1..];
        }
    }
}
