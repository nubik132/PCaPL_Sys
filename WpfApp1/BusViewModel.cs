using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Лаб29
{
    public class BusViewModel : INotifyPropertyChanged
    {
        private Bus bus;

        public BusViewModel(Bus p)
        {
            bus = p;
        }

        public int Seats
        {
            get { return bus.Seats; }
            set
            {
                bus.Seats = value;
                OnPropertyChanged("Seats");
            }
        }
        public int Busnumber
        {
            get { return bus.Busnumber; }
            set
            {
                bus.Busnumber = value;
                OnPropertyChanged("Bus number");
            }
        }
        public string Vodila
        {
            get { return bus.Vodila; }
            set
            {
                bus.Vodila = value;
                OnPropertyChanged("Vodila");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
