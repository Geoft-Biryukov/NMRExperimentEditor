using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMRExperimentEditor.Views
{
    public partial class ExperimentTableView : UserControl, IExperimentTableView
    {
        private readonly IExperimentCreator creator;

        public ExperimentTableView()
        {
            InitializeComponent();
        }

        public ExperimentTableView(IExperimentCreator creator)
        {
            InitializeComponent();
            
            this.creator = creator ?? throw new ArgumentNullException(nameof(creator));
        }

        private void OnSenthesizerFrequencyChanged(object sender, EventArgs e)
        {
            //FrequncyViewer.SynthesizerFrequency = creator.SynthesizerFrequency;
        }

        public IFrequencyView FrequncyViewer => frequencyView1;

        private void relaysView1_Load(object sender, EventArgs e)
        {

        }
    }
}
