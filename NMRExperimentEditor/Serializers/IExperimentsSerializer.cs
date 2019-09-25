using NMRExperimentEditor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Serializers
{
    internal interface IExperimentsSerializer
    {
        string Serialize(IEnumerable<ExperimentTable> experiment);
        IEnumerable<ExperimentTable> Deserialize(string source);
    }
}
