﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GongWPFDemo.ViewModels {
    internal class TaskViewModel {
        public TaskViewModel(string name, JobViewModel job) {
            this.Name = name;
        }
        public string Name { get; set; }
        public JobViewModel Job { get; set; }
    }
}
