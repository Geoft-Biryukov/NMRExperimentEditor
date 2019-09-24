using NMRExperimentEditor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMRExperimentEditor.Presenters
{
    class ExperimentTablePresenter
    {
        private readonly IExperimentTableView view;

        public ExperimentTablePresenter(IExperimentTableView view)
        {
            this.view = view ?? throw new ArgumentNullException(nameof(view));            
        }        
    }
}
