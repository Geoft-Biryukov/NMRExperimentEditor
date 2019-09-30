using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMRExperimentEditor.Views
{
    public partial class RelayCodeCalculator : Form
    {
        public RelayCodeCalculator()
        {
            InitializeComponent();
            relaysView1.Hexadecimal = hexCheckBox.Checked;
        }


        private void hexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            relaysView1.Hexadecimal = hexCheckBox.Checked;
        }
    }
}
