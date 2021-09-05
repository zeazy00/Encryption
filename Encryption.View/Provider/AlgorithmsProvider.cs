using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Encryption.Bll.Vigenere;
using Encryption.DI;

namespace Encryption.View.Provider
{
    public class AlgorithmsProvider
    {
        private readonly List<IEncryptionAlg> _algorithms = new();

        public IEnumerable<string> GetNames => _algorithms.Select(x => x.AlgorithmName);

        protected virtual void Setup()
        {
            
        }
    }
}
