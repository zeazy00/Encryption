using System.Collections.Generic;
using System.Linq;

using Encryption.Bll.Vigenere;
using Encryption.Config.Setup;
using Encryption.DI;
using Encryption.DI.Algorithm.Container;

namespace Encryption.Config
{
    public class AlgorithmsConfiguration
    {
        private readonly List<IAlgorithmContainer> _algorithms;

        private readonly ConfigFactory _configFactory;

        public AlgorithmsConfiguration()
        {
            _algorithms = new();
            _configFactory = new();

            Setup();
        }

        public IEnumerable<int> GetAvailableLabs()
        {
            return _algorithms.Select(x => x.LabNumber)
                              .Distinct();
        }

        public IEnumerable<string> GetAvailableAlgs(int labNumber)
        {
            return _algorithms.Where(x => x.LabNumber == labNumber)
                              .Select(x => x.AlgorithmName);
        }

        public IAlgorithmContainer GetAlg(string algName)
        {
            return _algorithms.SingleOrDefault(x => x.AlgorithmName == algName);
        }

        protected virtual void Setup()
        {
            IAlgorithmConfiguration algorithmConfiguration = _configFactory.GetDefault();

            _algorithms.Add(new VigenereAlgContainer(algorithmConfiguration));
        }
    }
}
