using NMRExperimentEditor.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Serializers
{
    internal class ExperementsImporter
    {
        public bool Import(Stream stream, out IEnumerable<ExperimentTable> experiments)
        {
            if (stream == null)
            {
                throw new ArgumentNullException(nameof(stream));
            }

            experiments = default(IEnumerable<ExperimentTable>);

            var result = new List<ExperimentTable>();

            var reader = new StreamReader(stream);

            string line = "";
            try
            {
                while ((line = reader.ReadLine()) != null)
                {

                    var array = ParseUshorts(line);
                    var experiment = new ExperimentTable();
                    experiment.SetArray(array);
                    result.Add(experiment);
                }
            }
            catch(ArgumentException)
            {
                return false;
            }

            experiments = result;

            return true;
        }

        private ushort[] ParseUshorts(string line)
        {
            var result = new List<ushort>();

            var values = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var val in values)
            {
                result.Add(Convert.ToUInt16(val.Trim(), 16));
            }

            return result.ToArray();
        }

        
    }
}
