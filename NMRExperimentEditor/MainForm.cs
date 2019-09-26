using NMRExperimentEditor.Model;
using NMRExperimentEditor.Presenters;
using NMRExperimentEditor.Serializers;
using NMRExperimentEditor.ViewModels;
using NMRExperimentEditor.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMRExperimentEditor
{    
    public partial class MainForm : Form, IMainView
    {              
        private readonly MainPresenter presenter;

        public MainForm()
        {
            InitializeComponent();           
            presenter = new MainPresenter(this);
        }

        #region IMainView implementation
        public bool ExperimentViewVisible
        {
            get => experimentView1.Visible;
            set => experimentView1.Visible = value;
        }

        public ExperimentTableViewModel SelectedExperiment
        {
            get => experimentsListBox.SelectedItem as ExperimentTableViewModel;
            set => experimentsListBox.SelectedItem = value;
        }

        public int SelectedIndex
        {
            get => experimentsListBox.SelectedIndex;
            set => experimentsListBox.SelectedIndex = value;
        }

        public void BindExperiments(BindingList<ExperimentTableViewModel> source)
            => experimentsListBox.DataSource = source ?? throw new ArgumentNullException(nameof(source));

        public void BindExperimentViewModel(ExperimentTableViewModel source)
            => experimentView1.BindViewModel(source);
        
        
        public string GetSaveExperimentsFileName(string filter)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = filter;

                if (dialog.ShowDialog() == DialogResult.OK)                
                    return dialog.FileName;                
                else
                    return string.Empty;
            }
        }

        public string GetOpenExperimentsFileName(string filter)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = filter;

                if (dialog.ShowDialog() == DialogResult.OK)
                    return dialog.FileName;
                else
                    return string.Empty;
            }
        }

        public void UpdateSelected()

        {
            experimentsListBox.ClearSelected();
            experimentsListBox.SelectedIndex = 0;
        }

        public void ShowInformation(string text, string caption)
            => MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        #endregion

        #region Event handlers

        #region Tools
        private void addButton_Click(object sender, EventArgs e) => presenter.AddExperiment();

        private void removeButton_Click(object sender, EventArgs e) => presenter.RemoveExperiment();
                       
        private void upButton_Click(object sender, EventArgs e) => presenter.UpExperiment();

        private void downButton_Click(object sender, EventArgs e) => presenter.DownExperiment();

        private void copyButton_Click(object sender, EventArgs e) => presenter.CopySelected();
        #endregion

        #region File menu
        private void save_Click(object sender, EventArgs e) => presenter.SaveExperiments();

        private void open_Click(object sender, EventArgs e) => presenter.OpenExperiments();

        private void exportButton_Click(object sender, EventArgs e) => presenter.Export();

        private void exitButton_Click(object sender, EventArgs e) => Close();
        #endregion

        #region Option
        private void hexToolStripMenuItem_Click(object sender, EventArgs e)
            => experimentView1.IsHexadecimal = hexToolStripMenuItem.Checked;
        #endregion

        private void experimentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (experimentsListBox.SelectedItem is ExperimentTableViewModel current)
                experimentView1.BindViewModel(current);
        }
        
        #endregion       

        
    }
}
