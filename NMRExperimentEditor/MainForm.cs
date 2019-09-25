using NMRExperimentEditor.Model;
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
    public partial class MainForm : Form, IExperimentCreator
    {
        private readonly Dictionary<TabPage, ExperimentTable> mapper = new Dictionary<TabPage, ExperimentTable>();
        private readonly BindingList<ExperimentTableViewModel> experiments = new BindingList<ExperimentTableViewModel>();

        public MainForm()
        {
            InitializeComponent();            
            experimentTableSimpleView1.Visible = false;
            experimentsListBox.DataSource = experiments;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            experimentTableSimpleView1.Visible = true;

            var experimentTable = new ExperimentTable()
            {
                ExperimentNumber = (ushort)experiments.Count
            };

            var viewModel = new ExperimentTableViewModel(experimentTable);

            experimentTableSimpleView1.BindViewModel(viewModel);

            experiments.Add(viewModel);
        }
      

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (experiments.Count == 0)
                return;           

            var selected = experimentsListBox.SelectedItem as ExperimentTableViewModel;
            int selectedIndex = experimentsListBox.SelectedIndex;
            experiments.Remove(selected);

            UpdateNumbers();
           
            if (experiments.Count == 0)
            {
                experimentTableSimpleView1.Visible = false;
            }
            else
            {
                experimentsListBox.SelectedIndex = Math.Max(selectedIndex - 1, 0);
            }

            experimentsListBox.Update();
        }

        private void UpdateNumbers()
        {
            experimentsListBox.DataSource = null;

            for (int i = 0; i < experiments.Count; i++)
            {
                experiments[i].ExperimentNumber = i;
            }
           
            experimentsListBox.DataSource = experiments;
        }

        private void experimentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (experimentsListBox.SelectedItem is ExperimentTableViewModel current)
                experimentTableSimpleView1.BindViewModel(current);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = experimentsListBox.SelectedIndex;

            if (selectedIndex == 0)
                return;

            SwapExperiments(selectedIndex);

            experimentsListBox.SelectedIndex = selectedIndex - 1;
            UpdateNumbers();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = experimentsListBox.SelectedIndex;

            if (selectedIndex == experiments.Count - 1)
                return;

            SwapExperiments(selectedIndex + 1);

            experimentsListBox.SelectedIndex = selectedIndex + 1;
            UpdateNumbers();
        }

        private void SwapExperiments(int index)
        {
            var tmp = experiments[index];
            experiments[index] = experiments[index - 1];
            experiments[index - 1] = tmp;
        }

        private IExperimentsSerializer serializer = new JsonExperimentsSerializer(); 

        private void save_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "Файл экспериментов|*.exp|Все файлы|*.*";

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = File.CreateText(dialog.FileName))
                    {
                        var json = serializer.Serialize(experiments.Select(item => item.Experimenent));
                        writer.Write(json);
                    }

                    MessageBox.Show("Файл успешно сохранен!", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Файл экспериментов|*.exp|Все файлы|*.*";                

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var reader = File.OpenText(dialog.FileName))
                    {
                        var source = reader.ReadToEnd();
                        var exps = serializer.Deserialize(source);

                        if (!exps.Any())
                            return;

                        experiments.Clear();
                        experimentTableSimpleView1.Visible = true;

                        foreach (var exp in exps)
                        {
                            var viewModel = new ExperimentTableViewModel(exp);
                            experiments.Add(viewModel);
                        }

                        experiments.ResetBindings();
                        
                        experimentsListBox.ClearSelected();
                        experimentsListBox.SelectedIndex = 0;
                    }

                   // MessageBox.Show("Файл успешно сохранен!", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
