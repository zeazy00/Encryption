using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Encryption.DI;

namespace Encryption.Bll.Vigenere
{
    public class VigenereAlg : IEncryptionAlg
    {
        public string AlgorithmName => "Vigenere";

        public int LabNumber => 1;

        public VigenereAlg()
        {

        }

        public string Cipher(string source)
        {
            throw new NotImplementedException();
        }

        public string Decipher(string source)
        {
            throw new NotImplementedException();
        }
    }
}
