using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NMRExperimentEditor.Presenters;

namespace NMRExperimentEditor.Views
{
    public partial class FrequencyView : UserControl, IFrequencyView
    {
        private readonly FrequencyPresenter persenter;
        private bool isUpdating = false;

        public FrequencyView()
        {
            InitializeComponent();

            persenter = new FrequencyPresenter(this);
            frequency.ValueChanged += OnFrequencyValueChanged;
            frequencyIndex.ValueChanged += OnFrequencyIndexValueChanged;
        }
       
        private void OnFrequencyValueChanged(object sender, EventArgs e)
        {
            Frequency = (double)frequency.Value;
        }

        private void OnFrequencyIndexValueChanged(object sender, EventArgs e)
        {
            FrequencyIndex = (uint)frequencyIndex.Value;
        }


        public uint FrequencyIndex
        {
            get => (uint)frequencyIndex.Value;
            set
            {
                frequencyIndex.Value = value;
                if(!isUpdating)
                    FrequencyIndexChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public double Frequency
        {
            get => (double)frequency.Value;
            set
            {
                frequency.Value = (decimal)value;
                if(!isUpdating)
                    FrequencyChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public byte Phase
        {
            get => (byte)phase.Value;
            set
            {
                phase.Value = value;
                if (!isUpdating)
                    PhaseChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public double SynthesizerFrequency { get; set; }

        

        public event EventHandler FrequencyIndexChanged;
        //{
        //    add { frequencyIndex.ValueChanged += value; }
        //    remove { frequencyIndex.ValueChanged -= value; }
        //}

        public event EventHandler FrequencyChanged;
        //{
        //    add { frequency.ValueChanged += value; }
        //    remove { frequency.ValueChanged -= value; }
        //}

        public event EventHandler PhaseChanged;
        //{
        //    add { phase.ValueChanged += value; }
        //    remove { phase.ValueChanged -= value; }
        //}

        public void BeginUpdate()
        {
            isUpdating = true;
        }

        public void EndUpdate()
        {
            isUpdating = false;
        }

        
    }
}
