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
    public partial class ExperimentTableSimpleView : UserControl
    {
        private readonly ExperimentTable table;

        public ExperimentTableSimpleView()
        {
            InitializeComponent();
        }

        public ExperimentTableSimpleView(ExperimentTable table)
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
    }
}
