using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
