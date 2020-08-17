using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryselle_Matienzo_Exercise02
{
    public static class ExtensionMethod
    {
        public static int CountWords(this StringBuilder value, string strobj)
        {
            // indicating each word is split by space, then store in IEnumerable string words, then return words count
            IEnumerable<string> words = strobj.Split(' ');
            return words.Count();
        } // end method
    } // end class
}
