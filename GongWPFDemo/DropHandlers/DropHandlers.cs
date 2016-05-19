using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using GongSolutions.Wpf.DragDrop;
using GongWPFDemo.ViewModels;

namespace GongWPFDemo.DropHandlers {
    internal class BaseDropHandler<T> : IDropTarget {
        public BaseDropHandler() { }
        public bool CanDrop(IDropInfo dropInfo) {
            return dropInfo.Data is T && dropInfo.TargetCollection is ObservableCollection<T>;
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
                var insertIntoCollection = (ObservableCollection<T>) dropInfo.TargetCollection;
                var removeFromCollection = (ObservableCollection<T>) dropInfo.DragInfo.SourceCollection;
                var moveItem = (T) dropInfo.Data;
                int insertionIndex = dropInfo.InsertIndex;
                if (insertIntoCollection.Contains(moveItem) && insertionIndex > insertIntoCollection.IndexOf(moveItem)) {
                    insertionIndex--;
                }
                removeFromCollection.Remove(moveItem);
                insertIntoCollection.Insert(insertionIndex, moveItem);
            }
        }
    }
    internal class JobViewDragHandler : BaseDropHandler<TaskViewModel> {
        public JobViewDragHandler() { }
    }
    internal class JobListViewDragHandler : BaseDropHandler<JobViewModel> {
        public JobListViewDragHandler() { }
    }
}
