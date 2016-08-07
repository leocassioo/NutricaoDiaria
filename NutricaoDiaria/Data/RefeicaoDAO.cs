using System;
using System.Collections.ObjectModel;
using SQLite;

namespace NutricaoDiaria
{


	public class RefeicaoDAO
	{
		private SQLiteConnection conexao;

		private ObservableCollection<Refeicao> lista;

		public ObservableCollection<Refeicao> Lista { 
			get {
				if (lista == null) {
					lista = GetAll();
				}
				return lista;
			}
			private set {
				lista = value;
			}
		
		}
		public RefeicaoDAO(SQLiteConnection con)
		{
			conexao = con;
			conexao.CreateTable<Refeicao>();
		}

		public void Remove(Refeicao refeicao) {
			conexao.Delete<Refeicao>(refeicao.ID);
			lista.Remove(refeicao);
		}

		public void Salvar(Refeicao refeicao) {
			conexao.Insert(refeicao);
			lista.Add(refeicao);
		}

		private ObservableCollection<Refeicao> GetAll() {
			

			return new ObservableCollection<Refeicao>(conexao.Table<Refeicao>());
		}

		//Listar por data

		//private ObservableCollection<Refeicao> GetDia() {

		//	var db = new SQLiteAsyncConnection(R);

		//	return new ObservableCollection<Refeicao>(conexao.ExecuteScalar<int>("SELECT * FROM Refeicao"));
		//}
	}
}

