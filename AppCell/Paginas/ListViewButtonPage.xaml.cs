using System;
using System.Collections.Generic;

using Xamarin.Forms;
using AppCell.Modelo;

namespace AppCell.Paginas
{
    public partial class ListViewButtonPage : ContentPage
    {
        public ListViewButtonPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Jose", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente Marketing" });
            Lista.Add(new Funcionario() { Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Nome = "Joao", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }

        private void FeriasAction(Object sender, EventArgs args)
        {
            Button btnFerias = (Button)sender;
            Funcionario func = (Funcionario)btnFerias.CommandParameter;
            DisplayAlert("Ferias", "Funcionario: " + func.Nome, "Ok");
        }
    }
}
