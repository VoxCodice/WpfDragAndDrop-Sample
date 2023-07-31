using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfDragAndDrop_Sample
{
    public class ListItem : INotifyPropertyChanged
    {
        private bool isDragged;
        private string text = "";
        private bool makeRoomAbove;
        private bool makeRoomBelow;

        public string Position { get; set; }
        public string Text { get => text; set => SetField(ref text, value); }
        public bool IsDragged { get => isDragged; set => SetField(ref isDragged, value); }
        public bool MakeRoomAbove { get => makeRoomAbove; set => SetField(ref makeRoomAbove, value); }
        public bool MakeRoomBelow { get => makeRoomBelow; set => SetField(ref makeRoomBelow, value); }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
