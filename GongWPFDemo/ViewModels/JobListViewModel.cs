using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GongWPFDemo.ViewModels {
  internal class JobListViewModel {
    public JobListViewModel() { }
    public ICollection<JobViewModel> Jobs { get; set; }
  }
}
