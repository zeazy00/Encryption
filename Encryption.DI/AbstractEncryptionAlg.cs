namespace Encryption.DI
{
    public abstract class AbstractEncryptionAlg : IEncryptionAlg
    {
        public abstract int LabNumber { get; }

        public abstract string AlgorithmName { get; }

        protected Alphabet Alphabet { get; private set; }

        protected string Key { get; private set; }

        public AbstractEncryptionAlg(IAlgorithmConfiguration configuration)
        {
            Alphabet = configuration.Alphabet;
            Key = configuration.Key;
        }

        public abstract string Cipher(string source);

        public abstract string Decipher(string source);
    }
}
