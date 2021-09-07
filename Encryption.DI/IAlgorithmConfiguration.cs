using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Encryption.DI.Algorithm;

namespace Encryption.DI
{
    public interface IAlgorithmConfiguration
    {
        public Alphabet Alphabet { get; }

        public string Key { get; }
    }
}
