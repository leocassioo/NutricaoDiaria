using System;
using SQLite;

namespace NutricaoDiaria
{
	public interface ISqlite
	{
		SQLiteConnection GetConnection();
	}
}

