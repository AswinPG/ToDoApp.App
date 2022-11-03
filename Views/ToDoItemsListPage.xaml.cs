using ToDoApp.ViewModels;

namespace ToDoApp.Views;

public partial class ToDoItemsListPage : ContentPage
{
	public ToDoItemsListPage()
	{
		BindingContext = new ToDoItemsListPageViewModel();

        InitializeComponent();
	}
}