using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EveEchoesManufacture.Contracts
{
    public class BaseObservable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string property)
        {
            PropertyChangedEventArgs eventArgs = new PropertyChangedEventArgs(property);
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
