using System;
using System.Windows.Input;

namespace WpfDragAndDrop_Sample
{
    public class DragStartCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            if (parameter is ListItem listItem)
                listItem.IsDragged = true;
        }
    }
}
