using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace NutricaoDiaria
{
	public class HomeTabbedPage : TabbedPage
	{
		public HomeTabbedPage()
		{
			
			SQLiteConnection con = DependencyService.Get<ISqlite>().GetConnection();

			RefeicaoDAO dao = new RefeicaoDAO(con);
			CadastroRefeicao telaCadastro = new CadastroRefeicao(dao);
			ListaRefeicao telaLista = new ListaRefeicao(dao);

			this.Children.Add(telaCadastro);
			this.Children.Add(telaLista);
		}
	}
}


