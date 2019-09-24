using NMRExperimentEditor.Model;
using NMRExperimentEditor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Presenters
{
    class FrequencyPresenter
    {
        private readonly IFrequencyView view;

        public FrequencyPresenter(IFrequencyView view)
        {
            this.view = view ?? throw new ArgumentNullException(nameof(view));

            view.FrequencyChanged += OnFrequencyChanged;
            view.FrequencyIndexChanged += OnFrequencyIndexChanged;
        }

        private void OnFrequencyIndexChanged(object sender, EventArgs e)
        {
            var freqIndex = view.FrequencyIndex;
            var sysClk = view.SynthesizerFrequency;

            var freq = Helpers.GetFrequencyByFrequencyIndex(freqIndex, sysClk);

            view.BeginUpdate();

            view.Frequency = freq * 1000;

            view.EndUpdate();
        }

        private void OnFrequencyChanged(object sender, EventArgs e)
        {
            var freq = view.Frequency / 1000;
            var sysClk = view.SynthesizerFrequency;

            var index = Helpers.GetFrequencyIndexByFrequency(freq, sysClk);

            view.BeginUpdate();

            view.FrequencyIndex = index;

            view.EndUpdate();
        }
    }
}
