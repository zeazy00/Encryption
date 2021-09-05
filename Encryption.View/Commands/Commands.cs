namespace Encryption.View.Commands
{
    enum Commands
    {
        [EnumString("Exit")]
        Exit,
        [EnumString("Show available labs")]
        ShowAvailableLabs,
        [EnumString("Cypher")]
        Cypher,
        [EnumString("Decipher")]
        Decipher,
    }
}
