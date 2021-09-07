namespace Encryption.DI.Algorithm
{
    public class Alphabet
    {
        public static Alphabet Ru { get; } = new Alphabet("абвгдежзийклмнопрстуфхцчшщъыьэюя");

        public static Alphabet Eng { get; } = new Alphabet("abcdefghijklmnopqrstuvwxyz");

        public string Items { get; }

        public int Capacity => Items.Length;

        public Alphabet(string items)
        {
            Items = items;
        }

        public char this[int index] => Items[index];
    }
}
