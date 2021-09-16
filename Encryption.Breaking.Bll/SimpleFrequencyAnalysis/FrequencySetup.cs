using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Encryption.Breaking.Bll.SimpleFrequencyAnalysis
{
    public class FrequencySetup
    {
        private readonly Dictionary<char, double> _frequencies;

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
