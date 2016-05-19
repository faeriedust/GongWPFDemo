using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GongWPFDemo.ViewModels {
  internal class TaskViewModel {
    public TaskViewModel(string name) { this.Name = name; }
    public string Name { get; set; }
  }
}
