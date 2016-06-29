using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NutricaoDiaria
{
	public partial class CadastroRefeicao : ContentPage
	{
		//private RefeicaoDAO dao;

		public CadastroRefeicao(RefeicaoDAO dao)
		{
			CadastroRefeicaoViewModel vm = new CadastroRefeicaoViewModel(dao, this);
			BindingContext = vm;
			InitializeComponent();
		}

		public void MostraLista(object Sender, EventArgs e)
		{
			ListaRefeicao tela = new ListaRefeicao();
			Navigation.PushAsync(tela);
		}


	}
}

