using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption.DI
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
    }
}
