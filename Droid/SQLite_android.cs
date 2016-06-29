using System;
using System.IO;
using NutricaoDiaria.Droid;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_android))]

namespace NutricaoDiaria.Droid
{
	public class SQLite_android : ISqlite
	{
		//public SQLite_android()
		//{
		//}

		public SQLiteConnection GetConnection()
		{
			var sqliteFilename = "Refeicaoes.db3";
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
			var path = Path.Combine(documentsPath, sqliteFilename);
			// Create the connection
			var conn = new SQLite.SQLiteConnection(path);
			// Return the database connection
			return conn;
		}
	}
}

