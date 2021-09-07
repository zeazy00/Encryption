namespace Encryption.DI.Algorithm.Container
{
    public interface IAlgorithmContainer
    {
        IEncryptionAlg EncryptionAlg { get; }

        int LabNumber { get; }

        string AlgorithmName { get; }

        bool ValidateSource(string source);
    }
}
