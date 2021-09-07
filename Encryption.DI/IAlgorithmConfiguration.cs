
using Encryption.DI.Algorithm;

namespace Encryption.DI
{
    public interface IAlgorithmConfiguration
    {
        public Alphabet Alphabet { get; }

        public string Key { get; }
    }
}
