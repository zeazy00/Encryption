using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using Newtonsoft.Json;

namespace Encryption.Breaking.Bll.SimpleFrequencyAnalysis
{
    public class FrequencySetup
    {
        private readonly Dictionary<char, double> _frequencies;

        //TODO: rename algorithms
        //TODO: add two algorithms and guess key length by first, second guesses key and length
        public FrequencySetup()
        {
            _frequencies = ExtractFrequencies().OrderBy(x => x.Value)
                                               .ToDictionary(x => x.Key, x => x.Value);
        }

        private Dictionary<char, double> ExtractFrequencies()
        {
            return JsonConvert.DeserializeObject<Dictionary<char, double>>(Properties.Resources.frequencies);
        }

        public double this[char item]=> _frequencies[item];
    }
}
