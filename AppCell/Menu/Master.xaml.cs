using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppCell.Menu
{
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        public void GoTextCell(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.TextCellPage());
            IsPresented = false;
        }

        public void GoImageCell(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.ImageCellPage());
            IsPresented = false;
        }

        public void GoEntryCell(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.EntryCellPage());
            IsPresented = false;
        }

        public void GoSwitchCell(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.SwitchCellPage());
            IsPresented = false;
        }

        public void GoViewCell(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.ViewCellPage());
            IsPresented = false;
        }

        public void GoListView(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.ListViewPage());
            IsPresented = false;
        }

        private void GoListViewButton(Object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.ListViewButtonPage());
            IsPresented = false;
        }
    }
}
