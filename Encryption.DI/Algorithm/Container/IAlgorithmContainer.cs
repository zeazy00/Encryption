using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.DI.Algorithm.Container
{
    public interface IAlgorithmContainer
    {
        IEncryptionAlg EncryptionAlg { get; }

        int LabNumber { get; }

        string AlgorithmName { get; }

        bool ValidateSource(string source);
    }
}
