using System;

namespace Encryption.DI.Algorithm
{
    public interface IEncryptionAlg
    {
        string Cipher(string source);

        string Decipher(string source);
    }
}
