namespace Encryption.View.Commands
{
    enum Commands
    {
        [EnumString("Exit")]
        Exit,
        [EnumString("Select algorithm")]
        SelectAlgorithm,
        [EnumString("Cipher")]
        Cipher,
        [EnumString("Decipher")]
        Decipher,
    }
}
