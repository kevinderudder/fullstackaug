using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures.Demo
{
    public static class StringExtensions
    {
        public static string ToXml(this string name, string elementName) {
            return $"<{elementName}>{name}</{elementName}>";
        }
    }
}
