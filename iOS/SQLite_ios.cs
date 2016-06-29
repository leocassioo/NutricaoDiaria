using System;
using System.IO;
using NutricaoDiaria.iOS;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_ios))]

namespace NutricaoDiaria.iOS
{
	public class SQLite_ios : ISqlite
	{
		public SQLite_ios()
		{
		}

		public SQLiteConnection GetConnection()
		{
			var fileName = "Refeicoes.db3";

			var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(documents, "..", "Library", fileName);

			return new SQLiteConnection(path);
		}
	}
}

