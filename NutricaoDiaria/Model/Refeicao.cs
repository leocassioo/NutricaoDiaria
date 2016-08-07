using System;
using SQLite;

namespace NutricaoDiaria
{
	public class Refeicao
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }


		public string Descricao { get; set; }
		public double Calorias { get; set; }

		public DateTime Data { get; set; } 


		public Refeicao() { }

		public Refeicao(string descricao, double calorias, DateTime data)
		{
			this.Descricao = descricao;
			this.Calorias = calorias;
			this.Data = data;
		}
	}
}

