﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using GongSolutions.Wpf.DragDrop;
using GongWPFDemo.ViewModels;

namespace GongWPFDemo.DropHandlers {
    internal class JobViewDragHandler : IDropTarget {
        public JobViewDragHandler() { }
        public bool CanDrop(IDropInfo dropInfo) {
            return dropInfo.Data is TaskViewModel && dropInfo.TargetCollection is ObservableCollection<TaskViewModel>;
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
                var myCollection = (ObservableCollection<TaskViewModel>) dropInfo.TargetCollection;
                var moveItem = (TaskViewModel) dropInfo.Data;
                int insertionIndex = dropInfo.InsertIndex;
                if (myCollection.Contains(moveItem)){
                    if (myCollection.IndexOf(moveItem) > insertionIndex) {
                        insertionIndex--;
                    }
                    myCollection.Remove(moveItem);
                }
                myCollection.Insert(insertionIndex, moveItem);
            }
        }
    }
}
