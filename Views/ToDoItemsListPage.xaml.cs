using ToDoApp.ViewModels;

namespace ToDoApp.Views;

public partial class ToDoItemsListPage : ContentPage
{
	public ToDoItemsListPage(ToDoItemsListPageViewModel vm)
	{
		BindingContext = vm;
		//BindingContext = new ToDoItemsListPageViewModel();

        InitializeComponent();
	}
}