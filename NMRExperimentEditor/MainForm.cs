using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMRExperimentEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            experimentsTabControl.TabPages.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var experimentControl = new Views.ExperimentTableView()
            {
                Dock = DockStyle.Fill
            };

            var newTab = new TabPage("Эксперимент");
            newTab.Controls.Add(experimentControl);

            experimentsTabControl.TabPages.Add(newTab);
        }
    }
}
