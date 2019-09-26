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
    public partial class ExperimentView : UserControl
    {
        private readonly ExperimentTable table;

        public ExperimentView()
        {
            InitializeComponent();
        }

        public ExperimentView(ExperimentTable table)
            : this()
        {
            this.table = table ?? throw new ArgumentNullException(nameof(table));            

            var viewModel = new ViewModels.ExperimentTableViewModel(table);
            experimentTableBidingSource.DataSource = viewModel;                                   
        }        

        internal void BindViewModel(ViewModels.ExperimentTableViewModel viewModel)
        {
            experimentTableBidingSource.DataSource = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
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
