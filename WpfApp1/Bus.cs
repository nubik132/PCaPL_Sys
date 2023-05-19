using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Лаб29
{
    public class Bus : INotifyPropertyChanged
    {
        private int seats;
        private int busnumber;
        private string vodila;

        public int Seats
        {
            get { return seats; }
            set
            {
                seats = value;
                OnPropertyChanged("Seats");
            }
        }
        public int Busnumber
        {
            get { return busnumber; }
            set
            {
                busnumber = value;
                OnPropertyChanged("Bus number");
            }
        }
        public string Vodila
        {
            get { return vodila; }
            set
            {
                vodila = value;
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

