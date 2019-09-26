using NMRExperimentEditor.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Serializers
{
    internal class ExperementsExporter : IExperimentsExporter
    {
        public void Export(Stream stream, IEnumerable<ExperimentTable> experiments)
        {
            if (stream == null)            
                throw new ArgumentNullException(nameof(stream));
            
            if (experiments == null)            
                throw new ArgumentNullException(nameof(experiments));            

            if (!experiments.Any())
                return;

            foreach (var experiment in experiments)
            {
                ExportExperiment(stream, experiment);
            }
        }

        private static void ExportExperiment(Stream stream, ExperimentTable experiment)
        {
            var array = experiment.GetArray();

            using (var writer = new StreamWriter(stream, Encoding.Unicode, 1024, true))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    var current = array[i].ToString("X4") + " ";
                    writer.Write(current);
                }

                writer.Write(Environment.NewLine);
            }
        }
    }
}
