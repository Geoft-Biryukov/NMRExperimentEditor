using NMRExperimentEditor.Model;
using NMRExperimentEditor.Views;
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
    public partial class MainForm : Form, IExperimentCreator
    {
        private readonly Dictionary<TabPage, ExperimentTable> mapper = new Dictionary<TabPage, ExperimentTable>();

        public MainForm()
        {
            InitializeComponent();
            experimentsTabControl.TabPages.Clear();    
            
        }              

        private void addButton_Click(object sender, EventArgs e)
        {

            SuspendLayout();
            experimentsTabControl.SuspendLayout();
            try
            {
                var experimentTable = new ExperimentTable()
                {
                    ExperimentNumber = (ushort)mapper.Count
                };

                var experimentControl = new Views.ExperimentTableSimpleView(experimentTable)
                {
                    Dock = DockStyle.Top,
                    AutoScroll = true
                };

                var newTab = new TabPage("Эксперимент")
                {
                    AutoScroll = true,
                };
                newTab.Controls.Add(experimentControl);

                experimentsTabControl.TabPages.Add(newTab);
                experimentsTabControl.SelectedTab = newTab;

                mapper.Add(newTab, experimentTable);
            }
            finally
            {
                ResumeLayout();
                experimentsTabControl.ResumeLayout();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selected = experimentsTabControl.SelectedTab;

            mapper.Remove(selected);
            experimentsTabControl.TabPages.Remove(selected);
        }
    }
}
