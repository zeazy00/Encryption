using System;

using Encryption.DI;
using Encryption.DI.Algorithm;

namespace Encryption.Bll.Vigenere
{
    sealed class VigenereAlg : AbstractEncryptionAlg
    {
        public VigenereAlg(IAlgorithmConfiguration configuration) : base(configuration)
        { }

        public override string Cipher(string source)
        {
            return $"ciphered! Key: {Key}";
        }

        public override string Decipher(string source)
        {
            return $"deciphered Alphabet: {Alphabet}";
        }
    }
}
