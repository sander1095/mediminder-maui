using MediMinder.Pages;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Application = Microsoft.Maui.Controls.Application;

namespace MediMinder
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//var tabbedPage = new MainPage();
			//tabbedPage.Children.Add(new FooPage());
			//tabbedPage.Children.Add(new FooPage());
			////tabbedPage.Children.Add(new BarPage());
			MainPage = new NavigationPage(new MainPage());
		}
	}
}
