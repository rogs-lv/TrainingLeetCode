using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class JewelsAndStones
    {
        /// <summary>
        /// Big O
        /// Complexity: O(n) because depending on how long take traverse the parameter "charsString", 
        /// while parameter "charsToSearch" only is limit to English letters and his access is by key into dictionary
        /// </summary>
        /// <param name="charsToSearch"></param>
        /// <param name="charsString"></param>
        /// <returns></returns>
        public int NumJewelsInStones(string charsToSearch, string charsString)
        {
            if (charsToSearch == null || charsString == null) return 0;

            Dictionary<char, int> dictionaryJewels = new Dictionary<char, int>();
            int sum = 0;
            for (int i = 0; i < charsToSearch.Length; i++)
            {
                dictionaryJewels[charsToSearch[i]] = 0;
            }

            for (int j = 0; j < charsString.Length; j++)
            {
                if (dictionaryJewels.ContainsKey(charsString[j]))
                    dictionaryJewels[charsString[j]]++;
            }

            foreach (var i in dictionaryJewels)
            {
                sum += i.Value;
            }
            return sum;
        }
    }
}
