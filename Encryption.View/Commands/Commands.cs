namespace Encryption.View.Commands
{
    enum Commands
    {
        [EnumString("Exit")]
        Exit,
        [EnumString("Show available labs")]
        ShowAvailableLabs,
        [EnumString("Cipher")]
        Cipher,
        [EnumString("Decipher")]
        Decipher,
    }
}
