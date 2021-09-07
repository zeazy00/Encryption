using System.Text;

using Encryption.DI;
using Encryption.DI.Algorithm;

namespace Encryption.Bll.Vigenere
{
    public sealed class VigenereAlg : AbstractEncryptionAlg
    {
        public VigenereAlg(IAlgorithmConfiguration configuration) : base(configuration)
        { }

        public override string Cipher(string source)
        {
            StringBuilder result = new();

            for (int i = 0; i < source.Length; i++)
            {
                //сумма в юникод
                int sum = source[i] + Key[i % Key.Length];
                //положение символа юникод в алфавите
                int itemInd = sum % Alphabet[0] % Alphabet.Capacity;

                result.Append(Alphabet[itemInd]);
            }

            return result.ToString();
        }

        public override string Decipher(string source)
        {
            StringBuilder result = new();

            for (int i = 0; i < source.Length; i++)
            {
                int sum = source[i] - Key[i % Key.Length];
                int itemInd = (sum + Alphabet.Capacity) % Alphabet.Capacity;

                result.Append(Alphabet[itemInd]);
            }

            return result.ToString();
        }
    }
}
