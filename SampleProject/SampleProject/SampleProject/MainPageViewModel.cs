using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace SampleProject
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            ExecuteGridCommand = new Command(ExecuteGridMethod);
            ExecuteButtonCommand = new Command(ExecuteButtonMethod);
        }

        private int _gridExecutionCount;
        public int GridExecutionCount
        {
            get => _gridExecutionCount;
            set
            {
                _gridExecutionCount = value;
                OnPropertyChanged();
            }
        }

        private int _buttonExecutionCount;
        public int ButtonExecutionCount
        {
            get => _buttonExecutionCount;
            set
            {
                _buttonExecutionCount = value;
                OnPropertyChanged();
            }
        }

        public Command ExecuteGridCommand { get; set; }

        public Command ExecuteButtonCommand { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void ExecuteGridMethod()
        {
            GridExecutionCount++;
        }

        public void ExecuteButtonMethod()
        {
            ButtonExecutionCount++;
        }
    }
}
