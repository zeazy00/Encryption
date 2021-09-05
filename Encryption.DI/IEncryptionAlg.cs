using System;

namespace Encryption.DI
{
    public interface IEncryptionAlg
    {
        int LabNumber { get; }

        string AlgorithmName { get; }

        string Cipher(string source);

        string Decipher(string source);
    }
}
