namespace Encryption.DI.Algorithm
{
    public abstract class AbstractEncryptionAlg : IEncryptionAlg
    {
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
