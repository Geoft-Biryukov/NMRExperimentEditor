using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NMRExperimentEditor.ViewModels;

namespace NMRExperimentEditor.Views
{
    interface IMainView
    {
        bool ExperimentViewVisible { get; set; }       
        void BindExperiments(BindingList<ViewModels.ExperimentTableViewModel> source);
        void BindExperimentViewModel(ViewModels.ExperimentTableViewModel source);
        ExperimentTableViewModel SelectedExperiment { get; set; }
        int SelectedIndex { get; set; }

        string GetSaveExperimentsFileName(string filter);
        string GetOpenExperimentsFileName(string filter);
        void ShowInformation(string text, string caption);
        void UpdateSelected();
    }
}
