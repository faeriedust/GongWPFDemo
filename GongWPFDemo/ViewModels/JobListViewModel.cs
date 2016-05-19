using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GongWPFDemo.ViewModels {
    internal class JobListViewModel {
        public JobListViewModel() {
            this.Jobs = new ObservableCollection<JobViewModel>();
        }
        public ObservableCollection<JobViewModel> Jobs { get; protected set; }
    }
}
