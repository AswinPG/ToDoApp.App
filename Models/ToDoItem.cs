using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class ToDoItem : INotifyPropertyChanged
    {
        string heading;
        public string Heading 
        { 
            get
            {
                return heading;
            }
            set
            {
                heading = value;
                NotifyPropertyChanged();
            }
        }
        string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                NotifyPropertyChanged();
            }
        }
        public DateTime Date { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
