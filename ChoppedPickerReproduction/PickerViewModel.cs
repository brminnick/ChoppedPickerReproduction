using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ChoppedPickerReproduction
{
    public class PickerViewModel : INotifyPropertyChanged
    {
        int _selectedNumber;
        List<int> _pickerNumberList;

        public PickerViewModel()
        {
            Task.Run(async () =>
            {
                await Task.Delay(2500);

                var pickerList = new List<int>();
                for (int i = 0; i < 1100; i++)
                    pickerList.Add(i);

                PickerNumberList = new List<int>(pickerList);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public List<int> PickerNumberList
        {
            get => _pickerNumberList;
            set
            {
                _pickerNumberList = value;
                OnPropertyChanged();
                SelectedNumberIndex = 250;
            }
        }

        public int SelectedNumberIndex
        {
            get => _selectedNumber;
            set
            {
                _selectedNumber = value;
                OnPropertyChanged();
            }
        }

        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
