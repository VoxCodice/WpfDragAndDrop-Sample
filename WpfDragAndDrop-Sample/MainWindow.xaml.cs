using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace WpfDragAndDrop_Sample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DragStartCommand = new DragStartCommand();
            DragStopCommand = new DragStopCommand();
            DragEnterCommand = new DragEnterCommand();
            DragLeaveCommand = new DragLeaveCommand();
            DragCompleteCommand = new DragCompleteCommand(RightItems);

            InitializeComponent();
        }

        public ICommand DragStartCommand { get; set; }
        public ICommand DragStopCommand { get; set; }
        public ICommand DragEnterCommand { get; set; }
        public ICommand DragLeaveCommand { get; set; }
        public ICommand DragCompleteCommand { get; set; }

        public ObservableCollection<ListItem> LeftItems { get; set; } = new()
        {
            new  () { Position = "left", Text = "Item 1" },
            new  () { Position = "left", Text = "Item 2" },
            new  () { Position = "left", Text = "Item 3" },
            new  () { Position = "left", Text = "Item 4" },
            new  () { Position = "left", Text = "Item 5" },
            new  () { Position = "left", Text = "Item 6" },
            new  () { Position = "left", Text = "Item 7" },
            new  () { Position = "left", Text = "Item 8" },
        };

        public ObservableCollection<ListItem> RightItems { get; set; } = new()
        {
            new  () { Position = "right", Text = "Item A" },
            new  () { Position = "right", Text = "Item B" },
            new  () { Position = "right", Text = "Item C" },
        };
    }
}
