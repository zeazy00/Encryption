﻿using System;

using Encryption.DI;

namespace Encryption.Bll.Vigenere
{
    public sealed class VigenereAlg : AbstractEncryptionAlg
    {
        public override string AlgorithmName => "Vigenere";

        public override int LabNumber => 1;

        public VigenereAlg(IAlgorithmConfiguration configuration) : base(configuration)
        { }

        public override string Cipher(string source)
        {
            throw new NotImplementedException();
        }

        public override string Decipher(string source)
        {
            throw new NotImplementedException();
        }
    }
}