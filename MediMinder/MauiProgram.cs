using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using SQLite;
using System.IO;
using System;
using MediMinder.Models;

namespace MediMinder
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			CreateDatabase();

			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			return builder.Build();
		}

		private static void CreateDatabase()
        {
			var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "mediminder.db");
			var _database = new SQLiteConnection(dbPath);
			_database.CreateTable<Medicine>();
			_database.Close();
		}
	}
}