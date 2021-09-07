namespace Encryption.DI.Algorithm.Container
{
    public abstract class AbstractAlgorithmContainer : IAlgorithmContainer
    {
        protected IAlgorithmConfiguration Configuration { get; private set; }

        public abstract IEncryptionAlg EncryptionAlg { get; }

        public abstract int LabNumber { get; }

        public abstract string AlgorithmName { get; }

        public AbstractAlgorithmContainer(IAlgorithmConfiguration configuration)
        {
            Configuration = configuration;
        }

        public virtual bool ValidateSource(string source)
        {
            if (string.IsNullOrWhiteSpace(source))
                return false;

            foreach (var item in source)
            {
                if (!Configuration.Alphabet.Items.Contains(item))
                    return false;
            }

            return true;
        }
    }
}
