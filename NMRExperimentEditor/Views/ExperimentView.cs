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
using NMRExperimentEditor.ViewModels;

namespace NMRExperimentEditor.Views
{
    public partial class ExperimentView : UserControl
    {        
        public ExperimentView()
        {
            InitializeComponent();
        }       

        internal void BindViewModel(ExperimentTableViewModel viewModel)
        {
            experimentTableBidingSource.DataSource = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
            wordsArrayGridView.DataSource = viewModel.WordsArray ?? throw new ArgumentNullException(nameof(viewModel.WordsArray));
        }

        private bool isHexadecimal = true;
        public bool IsHexadecimal
        {
            get => isHexadecimal;
            set
            {
                if (value == isHexadecimal)
                    return;

                isHexadecimal = value;
                foreach (var ctrl in tableLayoutPanel1.Controls)
                {
                    if (ctrl is NumericUpDown numericUpDown)
                        numericUpDown.Hexadecimal = isHexadecimal;
                }
            }
        }
    }
}
