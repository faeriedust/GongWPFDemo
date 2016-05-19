using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GongWPFDemo.ViewModels {
    internal class JobViewModel {
        public JobViewModel(string name) {
            this.Name = name;
            this.Tasks = new ObservableCollection<TaskViewModel>();
        }
        public string Name { get; set; }
        public ObservableCollection<TaskViewModel> Tasks { get; protected set; }
    }
}
