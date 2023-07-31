using System;
using System.Windows.Input;
using WpfDragAndDrop;

namespace WpfDragAndDrop_Sample
{
    public class DragEnterCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if (parameter is not DragEnterParams dragEnterParams)
                return;

            if (dragEnterParams.TargetObject is not ListItem listItem)
                return;

            listItem.MakeRoomAbove = dragEnterParams.DragEnterDirection.HasFlag(DragEnterDirection.North);
            listItem.MakeRoomBelow = dragEnterParams.DragEnterDirection.HasFlag(DragEnterDirection.South);
        }
    }
}
