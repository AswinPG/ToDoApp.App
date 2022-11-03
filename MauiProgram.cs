using ToDoApp.ViewModels;
using ToDoApp.Views;

namespace ToDoApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		Routing.RegisterRoute(nameof(ToDoItemsListPage), typeof(ToDoItemsListPage));

		builder.Services.AddTransient<ToDoItemsListPage>();
		builder.Services.AddTransient<ToDoItemsListPageViewModel>();


        return builder.Build();
	}
}
