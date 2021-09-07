
using Encryption.DI;
using Encryption.DI.Algorithm;

namespace Encryption.Test.Config
{
    class AlgConfig : IAlgorithmConfiguration
    {
        public Alphabet Alphabet { get; }

        public string Key { get; }

        public AlgConfig(string key, Alphabet alphabet)
        {
            Key = key;
            Alphabet = alphabet;
        }
    }
}
