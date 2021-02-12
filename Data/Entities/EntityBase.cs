using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FootballWCSB.Data.Entities
{
    public internal class EntityBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string source = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(source));
        }
    }
}