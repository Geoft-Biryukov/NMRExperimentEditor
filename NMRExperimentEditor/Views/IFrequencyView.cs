using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Views
{
    public interface IFrequencyView
    {
        uint FrequencyIndex { get; set; }
        double Frequency { get; set; }
        byte Phase { get; set; }

        event EventHandler FrequencyIndexChanged;
        event EventHandler FrequencyChanged;
        event EventHandler PhaseChanged;

        void BeginUpdate();
        void EndUpdate();
        
        double SynthesizerFrequency { get; set; }       
    }
}
