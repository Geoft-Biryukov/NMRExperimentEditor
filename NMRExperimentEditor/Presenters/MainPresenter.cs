using NMRExperimentEditor.Model;
using NMRExperimentEditor.Serializers;
using NMRExperimentEditor.ViewModels;
using NMRExperimentEditor.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMRExperimentEditor.Presenters
{
    class MainPresenter
    {
        private readonly IMainView view;
        private readonly BindingList<ExperimentTableViewModel> experiments = new BindingList<ExperimentTableViewModel>();
        private const string filterExp = "Файл экспериментов|*.exp|Все файлы|*.*";
        private const string filterArr = "Файл массива|*.arr|Все файлы|*.*";

        public MainPresenter(IMainView view)
        {
            this.view = view ?? throw new ArgumentNullException(nameof(view));

            view.BindExperiments(experiments);
            view.ExperimentViewVisible = false;
        }

        internal void AddExperiment()
        {
            view.ExperimentViewVisible = true;

            var experiment = new ExperimentTable()
            {
                ExperimentNumber = (ushort)experiments.Count
            };

            AddExperiment(experiment);

            //var viewModel = new ExperimentTableViewModel(experimentTable);
            //experiments.Add(viewModel);

            //view.BindExperimentViewModel(viewModel);
            //view.SelectedExperiment = viewModel;
        }

        private void AddExperiment(ExperimentTable experiment)
        {
            var viewModel = new ExperimentTableViewModel(experiment);
            experiments.Add(viewModel);

            view.BindExperimentViewModel(viewModel);
            view.SelectedExperiment = viewModel;
        }

        internal void RemoveExperiment()
        {
            if (experiments.Count == 0)
                return;

            var selected = view.SelectedExperiment;
            int selectedIndex = view.SelectedIndex;
            experiments.Remove(selected);

            UpdateNumbers();

            if (experiments.Count == 0)
            {
                view.ExperimentViewVisible = false;
            }
            else
            {
                view.SelectedIndex = Math.Max(selectedIndex - 1, 0);
            }
        }

        private void UpdateNumbers()
        {
            for (int i = 0; i < experiments.Count; i++)
            {
                experiments[i].ExperimentNumber = i;
            }
        }

        internal void UpExperiment()
        {
            int selectedIndex = view.SelectedIndex;

            if (selectedIndex == 0)
                return;

            SwapExperiments(selectedIndex);

            view.SelectedIndex = selectedIndex - 1;
            UpdateNumbers();
        }

        internal void DownExperiment()
        {
            int selectedIndex = view.SelectedIndex;

            if (selectedIndex == experiments.Count - 1)
                return;

            SwapExperiments(selectedIndex + 1);

            view.SelectedIndex = selectedIndex + 1;
            UpdateNumbers();
        }

        private void SwapExperiments(int index)
        {
            var tmp = experiments[index];
            experiments[index] = experiments[index - 1];
            experiments[index - 1] = tmp;
        }

        private IExperimentsSerializer serializer = new JsonExperimentsSerializer();

        internal void SaveExperiments()
        {
            string fileName = view.GetSaveExperimentsFileName(filterExp);

            if (string.IsNullOrEmpty(fileName))
                return;

            using (var writer = File.CreateText(fileName))
            {
                var json = serializer.Serialize(experiments.Select(item => item.Experimenent));
                writer.Write(json);
            }

            view.ShowInformation("Файл успешно сохранен!", "Сохранение файла");            
        }

        internal void OpenExperiments()
        {
            var fileName = view.GetOpenExperimentsFileName(filterExp);

            using (var reader = File.OpenText(fileName))
            {
                var source = reader.ReadToEnd();
                var exps = serializer.Deserialize(source);

                if (!exps.Any())
                    return;

                experiments.Clear();
                view.ExperimentViewVisible = true;

                foreach (var exp in exps)
                {
                    var viewModel = new ExperimentTableViewModel(exp);
                    experiments.Add(viewModel);
                }

                experiments.ResetBindings();

                view.UpdateSelected();               
            }
        }

        internal void CopySelected()
        {
            var selected = view.SelectedExperiment;
            var copied = (ExperimentTable)(selected.Experimenent.Clone());
            copied.ExperimentNumber = (ushort)experiments.Count;

            AddExperiment(copied);
        }

        internal void Export()
        {
            var fileName = view.GetSaveExperimentsFileName(filterArr);
            var exporter = new ExperimentsExporter();

            using (var stream = new FileStream(fileName, FileMode.Create,FileAccess.Write))
            {                
                exporter.Export(stream, experiments.Select(item => item.Experimenent));
            }

            view.ShowInformation("Файл успешно экспортирован.", "Экпорт экспериментов");
        }
    }
}
