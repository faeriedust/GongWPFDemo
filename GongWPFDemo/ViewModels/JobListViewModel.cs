using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GongWPFDemo.ViewModels {
    internal class JobListViewModel {
        public JobListViewModel() { }
        public ObservableCollection<JobViewModel> Jobs { get; set; }
    }
}
