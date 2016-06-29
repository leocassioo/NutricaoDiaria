using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace NutricaoDiaria
{
	public partial class ListaRefeicao : ContentPage
	{
		public ObservableCollection<Refeicao> Refeicoes { get; set; }

		private RefeicaoDAO dao;

		public ListaRefeicao(RefeicaoDAO dao)
		{

			BindingContext = this;
			this.dao = dao;
			Refeicoes = dao.Lista;
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

