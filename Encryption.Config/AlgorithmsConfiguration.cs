using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Encryption.Bll.Vigenere;
using Encryption.DI;

namespace Encryption.Config
{
    public class AlgorithmsConfiguration
    {
        private readonly List<IEncryptionAlg> _algorithms;

        public AlgorithmsConfiguration()
        {
            _algorithms = new List<IEncryptionAlg>();
            Setup();
        }

        protected virtual void Setup()
        {
            IAlgorithmConfiguration algorithmConfiguration = GetConfiguration();

            _algorithms.Add(new VigenereAlg(algorithmConfiguration));
        }

        protected virtual IAlgorithmConfiguration GetConfiguration()
        {
            throw new NotImplementedException();
        }
    }
}
