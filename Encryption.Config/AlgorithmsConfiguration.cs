using System.Collections.Generic;

using Encryption.Bll.Vigenere;
using Encryption.Config.Setup;
using Encryption.DI;

namespace Encryption.Config
{
    public class AlgorithmsConfiguration
    {
        private readonly List<IEncryptionAlg> _algorithms;

        private readonly ConfigFactory _configFactory;

        public AlgorithmsConfiguration()
        {
            _algorithms = new List<IEncryptionAlg>();
            Setup();
        }

        protected virtual void Setup()
        {
            IAlgorithmConfiguration algorithmConfiguration = _configFactory.GetDefault();

            _algorithms.Add(new VigenereAlg(algorithmConfiguration));
        }
    }
}
