using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Model
{
    [Flags]
    public enum RelayStatus : byte
    {
        Empty = 0,
        Relay1 = 1 << 0,
        Relay2 = 1 << 1,
        Relay3 = 1 << 2,
        Relay4 = 1 << 3,
        Relay5 = 1 << 4,
        Relay6 = 1 << 5,
    }
}
