using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using SQLite;

namespace NutricaoDiaria
{
	public partial class ListaRefeicao : ContentPage
	{
		public ObservableCollection<Refeicao> Refeicoes { get; set; }
		//public ObservableCollection<Refeicao> Hue {}

		private RefeicaoDAO dao;


		public ListaRefeicao(RefeicaoDAO dao)
		{

			BindingContext = this;
			this.dao = dao;

			Refeicoes = dao.Lista;
			//Refeicoes = dao.diaSeparado;
			InitializeComponent();
		}

		public ListaRefeicao()
		{
		}


		public async void AcaoItem(object sender, ItemTappedEventArgs e)
		{

			Refeicao refeicao = e.Item as Refeicao;

			var resposta = await DisplayAlert("Remover Item", "Tem certeza que deseja remover a refeicao " + refeicao.Descricao, "Sim", "Não");

			if (resposta)
			{
				dao.Remove(refeicao);
				await DisplayAlert("Remover Item", "Refeição removida com sucesso", "Ok");
			}

		}
	}
}

