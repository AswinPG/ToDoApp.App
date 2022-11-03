using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
using ToDoApp.Views;

namespace ToDoApp.ViewModels
{
    [ObservableObject]
    public partial class ToDoItemsListPageViewModel
    {
        [ObservableProperty]
        ToDoItem newToDoItem;
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }

        
        public ToDoItemsListPageViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();
            NewToDoItem = new ToDoItem();
        }

        [RelayCommand]
        public async Task Navigate()
        {
            await Shell.Current.GoToAsync(nameof(ToDoItemsListPage));
        }

        [RelayCommand]
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
