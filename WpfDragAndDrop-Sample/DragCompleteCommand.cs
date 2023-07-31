using System;
using System.Collections.Generic;
using System.Windows.Input;
using WpfDragAndDrop;

namespace WpfDragAndDrop_Sample
{
    public class DragCompleteCommand : ICommand
    {
        private IList<ListItem> listItems;

        public DragCompleteCommand(IList<ListItem> listItems)
        {
            this.listItems = listItems;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if (parameter is not DragCompleteParams dragCompleteParams)
                return;

            if (dragCompleteParams.DraggableObject is not ListItem draggedListItem)
                return;

            if (dragCompleteParams.TargetObject is not ListItem targetListItem)
                return;

            var index = listItems.IndexOf(targetListItem);
            if (index < 0)
                return;

            var toBeInserted = new ListItem()
            {
                Position = draggedListItem.Position,
                Text = draggedListItem.Text
            };

            if (dragCompleteParams.DragEnterDirection.HasFlag(DragEnterDirection.North))
                listItems.Insert(index, toBeInserted);
            else
                listItems.Insert(index + 1, toBeInserted);
        }
    }
}
