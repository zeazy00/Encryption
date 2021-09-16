using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Encryption.Breaking.Bll.SimpleFrequencyAnalysis;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Encryption.Test.Lab3
{
    [TestClass]
    public class FrequencySetupTest
    {
        readonly FrequencySetup _frequencySetup = new FrequencySetup();

        [TestMethod]
        public void GetFrequencies()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                double freq = _frequencySetup[c];
                Assert.IsTrue(freq > 0);
            }
        }
    }
}
