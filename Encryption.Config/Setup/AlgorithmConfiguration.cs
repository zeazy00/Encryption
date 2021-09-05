
using Encryption.DI;

namespace Encryption.Config.Setup
{
    class AlgorithmConfiguration : IAlgorithmConfiguration
    {
        public Alphabet Alphabet { get; }

        public string Key { get; }

        public AlgorithmConfiguration(string key, Alphabet alphabet)
        {
            Key = key;
            Alphabet = alphabet;
        }
    }
}
