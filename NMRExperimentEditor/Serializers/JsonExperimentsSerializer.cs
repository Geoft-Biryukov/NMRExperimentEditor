using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMRExperimentEditor.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace NMRExperimentEditor.Serializers
{
    class JsonExperimentsSerializer : IExperimentsSerializer
    {
        public IEnumerable<ExperimentTable> Deserialize(string source)
        {
            if (source == null)            
                throw new ArgumentNullException(nameof(source));            

            return JsonConvert.DeserializeObject<IEnumerable<ExperimentTable>>(source);
        }

        public string Serialize(IEnumerable<ExperimentTable> experiments)
        {
            if (experiments == null)            
                throw new ArgumentNullException(nameof(experiments));

            if (!experiments.Any())
                return string.Empty;
            
            return JsonConvert.SerializeObject(experiments, Formatting.Indented);
        }
    }
}
