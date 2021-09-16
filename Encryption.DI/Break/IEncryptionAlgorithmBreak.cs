using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.DI.Break
{
    public interface IEncryptionAlgorithmBreak
    {
        string Decipher(string source);
    }
}
