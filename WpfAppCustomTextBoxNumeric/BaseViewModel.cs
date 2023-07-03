using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfAppCustomTextBoxNumeric
{
    public class BaseViewModel : INotifyPropertyChanged
    {
     

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}