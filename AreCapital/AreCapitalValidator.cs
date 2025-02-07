using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreCapital
{
    public static class AreCapitalValidator
    {
        public static bool DetectCapitalUse(string word)
        {
            if (word == word.ToUpper())
                return true;
            if (word == word.ToLower())
                return true;
            if (char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower())
                return true;
            return false;
        }
    }
}
