using System;
using System.Windows.Input;

namespace WpfDragAndDrop_Sample
{
    public class DragLeaveCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if (parameter is not ListItem listItem)
                return;

            listItem.MakeRoomAbove = false;
            listItem.MakeRoomBelow = false;
        }
    }
}
