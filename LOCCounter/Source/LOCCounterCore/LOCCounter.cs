using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LOCCounterCore
{
    public static class LOCCounter
    {
        public static int Count(string codeFile)
        {
            return File.ReadAllLines(codeFile)
                .FilterEmptyLine()
                .FilterSingleLineComment()
                .FilterMultiLineComment()
                .Count();
        }
        
        static internal IEnumerable<string> FilterEmptyLine(this IEnumerable<string> source)
        {
            return source.Where(line => line.Trim() != "");
        }

        static internal IEnumerable<string> FilterSingleLineComment(this IEnumerable<string> source)
        {
            return source.Where(line => !line.Trim().StartsWith("//"));
        }

        static internal IEnumerable<string> FilterMultiLineComment(this IEnumerable<string> source)
        {
            var isInComment = false;
            foreach(var line in source)
            {
                if (line.Contains("/*"))
                {
                    isInComment = true;
                }

                if (!isInComment)
                {
                    yield return line;
                }
                    

                if(line.Contains("*/") && isInComment)
                {
                    isInComment = false;
                }


            }

            //source.Where(line => line.Contains("/*"));
        }
    }
}
