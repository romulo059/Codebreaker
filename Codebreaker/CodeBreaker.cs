using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreaker
{
    public class Code
    {
        private static readonly Random Random = new Random();
        public static string[] AllowedChars = new string[] { "R", "A", "M", "V", "I", "N" };

        public string GetCode()
        {
            var code = string.Empty;
            for (var i = 0; i < 4; i++)
                code = string.Concat(code, AllowedChars[Random.Next(4)]);
            return code;
        }
    }
}
