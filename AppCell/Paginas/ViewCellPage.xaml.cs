﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using AppCell.Modelo;

namespace AppCell.Paginas
{
    public partial class ViewCellPage : ContentPage
    {
        public ViewCellPage()
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
    }
}
