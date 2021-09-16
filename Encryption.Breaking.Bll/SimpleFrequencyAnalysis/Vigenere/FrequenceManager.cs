using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.Breaking.Bll.SimpleFrequencyAnalysis.Vigenere
{
    internal static class FrequenceManager
    {
        public static Dictionary<char, double> ExtractFrequencies(string source)
        {
            Dictionary<char, double> souceFrequencies = new Dictionary<char, double>();

            foreach (char c in source)
            {
                if (souceFrequencies.ContainsKey(c))
                {
                    souceFrequencies.Add(c, 1);
                }
                else
                {
                    souceFrequencies[c] = souceFrequencies[c]++;
                }
            }

            return souceFrequencies.ToDictionary(x => x.Key,
                                                 x => x.Value / source.Length);
        }
    }
}
