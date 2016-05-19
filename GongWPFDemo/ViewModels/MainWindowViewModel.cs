using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace GongWPFDemo.ViewModels {
    internal class MainWindowViewModel {
        public MainWindowViewModel() {
            this.JobList = new JobListViewModel {
                Jobs = new ObservableCollection<JobViewModel>() {
                    new JobViewModel("Job A") {
                        Tasks = new ObservableCollection<TaskViewModel>() {
                            new TaskViewModel("Task A"),
                            new TaskViewModel("Task B"),
                            new TaskViewModel("Task C")
                        }
                    },
                    new JobViewModel("Job B") {
                        Tasks = new ObservableCollection<TaskViewModel>() {
                            new TaskViewModel("Task D"),
                            new TaskViewModel("Task E"),
                        }
                    },
                    new JobViewModel("Job C") {
                        Tasks = new ObservableCollection<TaskViewModel>() {
                            new TaskViewModel("Task F")
                        }
                    }
                }
            };
        }
        public JobListViewModel JobList { get; set; }
    }
}
