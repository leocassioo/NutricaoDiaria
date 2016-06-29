using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace NutricaoDiaria
{
	public class CadastroRefeicaoViewModel : INotifyPropertyChanged
	{

		private string descricao;
		private double calorias;

		public string Descricao { 
			get {
				return descricao;
			}
			set {
				if (value != descricao)
				{
					descricao = value;
					OnPropertyChanged("Descricao");
				}
			}
		}

		public double Calorias { 
			get {
				return calorias;
			}
			set {
				if (calorias != value)
				{
					calorias = value;
					OnPropertyChanged("Calorias");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private RefeicaoDAO dao;
		private ContentPage page;
		public ICommand SalvaRefeicao { get; protected set;}

		public CadastroRefeicaoViewModel(RefeicaoDAO dao, ContentPage page)
		{
			this.dao = dao;
			this.page = page;

			SalvaRefeicao = new Command(() => { 
				if (descricao == null)
				{
					this.page.DisplayAlert("Erro", "Por favor preenchar os campos corretamente", "Ok");
				}
				else {

					Refeicao refeicao = new Refeicao(descricao, calorias);
					dao.Salvar(refeicao);

					string msg = "A refeição " + descricao + " de " + calorias + " calorias foi salva com sucesso! ";

					this.page.DisplayAlert("Savar Refeição", msg, "Ok");
				}
			});
		}

		private void OnPropertyChanged(string nome) {
			PropertyChanged(this, new PropertyChangedEventArgs(nome)); 
		}

	}
}

