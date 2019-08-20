using System;
using System.Collections.Generic;

using Xamarin.Forms;
using AppCell.Modelo;

namespace AppCell.Detalhe
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Funcionario funcionario)
        {
            InitializeComponent();

            TxtNome.Text = funcionario.Nome;
        }
    }
}
