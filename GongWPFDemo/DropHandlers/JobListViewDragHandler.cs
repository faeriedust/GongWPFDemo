using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using GongSolutions.Wpf.DragDrop;
using GongWPFDemo.ViewModels;

namespace GongWPFDemo.DropHandlers {
    internal class JobListViewDragHandler : IDropTarget {
        public JobListViewDragHandler() { }
        public bool CanDrop(IDropInfo dropInfo) {
            return dropInfo.Data is JobViewModel;
        }
        public void DragOver(IDropInfo dropInfo) {
            if (this.CanDrop(dropInfo)) {
                dropInfo.Effects = DragDropEffects.Move;
                dropInfo.DropTargetAdorner = DropTargetAdorners.Insert;
            } else {
                dropInfo.Effects = DragDropEffects.None;
            }
        }
        public void Drop(IDropInfo dropInfo) {
            if (this.CanDrop(dropInfo)) {
                var myCollection = (ICollection<JobViewModel>) dropInfo.TargetCollection;
                var insertionItem = (JobViewModel) dropInfo.Data;
            }
        }
    }
}
