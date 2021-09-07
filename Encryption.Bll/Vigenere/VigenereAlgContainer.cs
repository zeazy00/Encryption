
using Encryption.DI;
using Encryption.DI.Algorithm;
using Encryption.DI.Algorithm.Container;

namespace Encryption.Bll.Vigenere
{
    public sealed class VigenereAlgContainer : AbstractAlgorithmContainer
    {
        public override IEncryptionAlg EncryptionAlg { get; }

        public override string AlgorithmName => "Vigenere";

        public override int LabNumber => 1;

        public VigenereAlgContainer(IAlgorithmConfiguration configuration) : base(configuration)
        {
            EncryptionAlg = new VigenereAlg(configuration);
        }
    }
}
