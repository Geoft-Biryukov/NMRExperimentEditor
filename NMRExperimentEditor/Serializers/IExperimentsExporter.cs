using NMRExperimentEditor.Model;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace NMRExperimentEditor.Serializers
{
    internal interface IExperimentsExporter
    {
        void Export(Stream stream, IEnumerable<ExperimentTable> experiments);
    }
}