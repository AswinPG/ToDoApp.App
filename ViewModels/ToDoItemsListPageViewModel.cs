using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class ToDoItemsListPageViewModel : INotifyPropertyChanged
    {
        ToDoItem toDo;
        public ToDoItem NewToDoItem 
        { 
            get
            {
                return toDo;
            } 
            set
            {
                toDo = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }


        public ToDoItemsListPageViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();
            NewToDoItem = new ToDoItem();
            AddCommand = new Command(()=>AddToDoItem());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public ICommand AddCommand { get; }



        public void AddToDoItem()
        {
            if (String.IsNullOrEmpty(NewToDoItem.Heading))
            {
                return;
            }
            else if(String.IsNullOrEmpty(NewToDoItem.Description))
            {

            }
            else
            {
                ToDoItems.Add(NewToDoItem);
                NewToDoItem = new ToDoItem();
            }
        }
    }
}
