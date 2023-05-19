﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Лаб29
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Bus selectedBus;
        
        private RelayCommand removeCommand;
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Bus bus = new Bus() { Seats = 52, Busnumber = 11, Vodila = "Phil" };
                      Buses.Insert(0, bus);
                      SelectedBus = bus;
                  }));
            }
        }
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      Bus bus = obj as Bus;
                      if (bus != null)
                      {
                          Buses.Remove(bus);
                      }
                  },
                 (obj) => Buses.Count > 0));
            }
        }
        private RelayCommand doubleCommand;
        public RelayCommand DoubleCommand
        {
            get
            {
                return doubleCommand ??
                    (doubleCommand = new RelayCommand(obj =>
                    {
                        Bus bus = obj as Bus;
                        if (bus != null)
                        {
                            Bus busCopy = new Bus
                            {
                                Vodila = bus.Vodila,
                                Busnumber = bus.Busnumber,
                                Seats = bus.Seats
                            };
                            Buses.Insert(0, busCopy);
                        }
                    }));
            }
        }


        public ObservableCollection<Bus> Buses { get; set; }
        public Bus SelectedBus
        {
            get { return selectedBus; }
            set
            {
                selectedBus = value;
                OnPropertyChanged("SelectedBus");
            }
        }

        public ApplicationViewModel()
        {
            Buses = new ObservableCollection<Bus>
            {
                new Bus {Seats=52, Busnumber=11, Vodila="Phil" },
                new Bus {Seats=52, Busnumber=8, Vodila ="Nikita" },
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}





