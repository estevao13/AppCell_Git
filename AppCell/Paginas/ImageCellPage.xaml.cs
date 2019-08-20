using System;
using System.Collections.Generic;

using Xamarin.Forms;
using AppCell.Modelo;

namespace AppCell.Paginas
{
    public partial class ImageCellPage : ContentPage
    {
        public ImageCellPage()
        {
            InitializeComponent();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Jose", Cargo = "Presidente" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Maria", Cargo = "Gerente de Vendas" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Elaine", Cargo = "Gerente Marketing" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Felipe", Cargo = "Entregador" });
            Lista.Add(new Funcionario() { Foto = "perfil.png", Nome = "Joao", Cargo = "Vendedor" });

            ListaFuncionario.ItemsSource = Lista;
        }
    }
}
