using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NMRExperimentEditor.Model;

namespace NMRExperimentEditor.Views
{
    public partial class FrequencyCalculator : UserControl
    {
        public FrequencyCalculator()
        {
            InitializeComponent();
            EnableControls();
        }

        private void frequencyByIndex_CheckedChanged(object sender, EventArgs e)
        {
            EnableControls();
        }

        private void EnableControls()
        {
            frequency.Enabled = !frequencyByIndex.Checked;
            frequencyIndex.Enabled = frequencyByIndex.Checked;
        }

        private void Calculate()
        {
            if (frequencyByIndex.Checked)
                CalculateFrequencyByIndex();
            else
                CalculateIndexByFrequency();
        }

        private void CalculateFrequencyByIndex()
        {                        
            Frequency = Helpers.GetFrequencyByFrequencyIndex(Index, SynthesizerFrequency);
        }

        private void CalculateIndexByFrequency()
        {
            Index = Helpers.GetFrequencyIndexByFrequency(Frequency, SynthesizerFrequency);
        }

        private double SynthesizerFrequency
        {
            get => (double)synthesizerFrequency.Value;
            set
            {
                if ((double)synthesizerFrequency.Value == value)
                    return;

                synthesizerFrequency.Value = (decimal)value;
            }
        }

        private double Frequency
        {
            get => (double)frequency.Value;
            set
            {
                if ((double)frequency.Value == value)
                    return;

                frequency.Value = (decimal)value;
            }
        }

        private uint Index
        {
            get => (uint)frequencyIndex.Value;
            set
            {
                if ((uint)frequencyIndex.Value == value)
                    return;
                frequencyIndex.Value = value;
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void hexFrequencyIndex_CheckedChanged(object sender, EventArgs e)
        {
            frequencyIndex.Hexadecimal = hexFrequencyIndex.Checked;
        }
    }
}
