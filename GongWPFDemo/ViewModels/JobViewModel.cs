using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GongWPFDemo.ViewModels {
  internal class JobViewModel {
    public JobViewModel() { }
    public string Name { get; set; }
    public ICollection<TaskViewModel> Tasks { get; set; }
  }
}
