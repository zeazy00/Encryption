using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Encryption.DI.Analysis;

namespace Encryption.Breaking.Bll.SimpleFrequencyAnalysis.Vigenere
{
    public class VigenereBreaking : IEncryptionAlgorithmBreak
    {
        public string Decipher(string source)
        {
            //page 45
            Dictionary<char, double> frequencies = FrequenceManager.ExtractFrequencies(source);
            return null;
        }


    }
}
