using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GongWPFDemo.ViewModels {
  internal class MainWindowViewModel {
    public MainWindowViewModel() {
      this.JobList = new JobListViewModel {
        Jobs = new List<JobViewModel>() {
          new JobViewModel("Job A") {
            Tasks=new List<TaskViewModel>() {
              new TaskViewModel("Task A"),
            }
          },
          new JobViewModel("Job B") {
            Tasks = new List<TaskViewModel>() {
              new TaskViewModel("Task B"),
              new TaskViewModel("Task C")
            }
          },
          new JobViewModel("Job C") {
            Tasks = new List<TaskViewModel>() {
              new TaskViewModel("Task D"),
              new TaskViewModel("Task E"),
              new TaskViewModel("Task F")
            }
          }
        }
      };
    }
    public JobListViewModel JobList { get; set; }
  }
}
