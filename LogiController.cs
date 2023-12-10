
using ExternalAccessory;
using RastreioLogi.Models;
using System.ComponentModel;

namespace RastreioLogi.ViewModel 
{
    public partial class LogiController : INotifyPropertyChanged
    {
        LogiDados logiControl = new LogiDados();

        LogiController ViewController = new LogiController();

        await
      void  OnPropertyChagned(logicontrol.id);

        public event PropertyChangedEventHandler PropertyChanged;
        void OnProperyChanged(LogiDados) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(logiControl));

     }
}

