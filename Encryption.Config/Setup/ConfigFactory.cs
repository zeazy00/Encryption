using System.Configuration;

using Encryption.DI;
using Encryption.DI.Algorithm;

namespace Encryption.Config.Setup
{
    class ConfigFactory
    {
        public IAlgorithmConfiguration GetDefault()
        {
            string key = ConfigurationManager.AppSettings["key"];
            Alphabet alphabet = ConfigAlphabet();

            return new AlgorithmConfiguration(key, alphabet);
        }


        private Alphabet ConfigAlphabet()
        {
            var alphabet = ConfigurationManager.AppSettings["alphabet"].ToLower();

            return alphabet switch
            {
                "ru" => Alphabet.Ru,
                "eng" => Alphabet.Eng,
                _ => new Alphabet(alphabet),
            };
        }
    }
}
