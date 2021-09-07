using Encryption.Bll.Vigenere;
using Encryption.DI;
using Encryption.DI.Algorithm;
using Encryption.Test.Config;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Encryption.Test
{
    [TestClass]
    public class VigenereTest
    {
        [TestMethod]
        public void CipherEngExampleFromManual()
        {
            //arrange
            string source = "thiscryptosystemisnotsecure";
            IAlgorithmConfiguration algorithmConfiguration = new AlgConfig("cipher", Alphabet.Eng);
            IEncryptionAlg encryptionAlg = new VigenereAlg(algorithmConfiguration);

            //act
            string result = encryptionAlg.Cipher(source);

            //assert
            Assert.AreEqual("vpxzgiaxivwpubttmjpwizitwzt", result);
        }

        [TestMethod]
        public void CipherRuExample()
        {
            //arrange
            string source = "карлукларыукралкораллы";
            IAlgorithmConfiguration algorithmConfiguration = new AlgConfig("кларнет", Alphabet.Ru);
            IEncryptionAlg encryptionAlg = new VigenereAlg(algorithmConfiguration);

            //act
            string result = encryptionAlg.Cipher(source);

            //assert
            Assert.AreEqual("флрыапэкыыгчхтххоанрэе", result);
        }

        [TestMethod]
        public void DecipherEngExampleFromManual()
        {
            //arrange
            string source = "vpxzgiaxivwpubttmjpwizitwzt";
            IAlgorithmConfiguration algorithmConfiguration = new AlgConfig("cipher", Alphabet.Eng);
            IEncryptionAlg encryptionAlg = new VigenereAlg(algorithmConfiguration);

            //act
            string result = encryptionAlg.Decipher(source);

            //assert
            Assert.AreEqual("thiscryptosystemisnotsecure", result);
        }

        [TestMethod]
        public void DecipherRuExample()
        {
            //arrange
            string source = "флрыапэкыыгчхтххоанрэе";
            IAlgorithmConfiguration algorithmConfiguration = new AlgConfig("кларнет", Alphabet.Ru);
            IEncryptionAlg encryptionAlg = new VigenereAlg(algorithmConfiguration);

            //act
            string result = encryptionAlg.Decipher(source);

            //assert
            Assert.AreEqual("карлукларыукралкораллы", result);
        }
    }
}
