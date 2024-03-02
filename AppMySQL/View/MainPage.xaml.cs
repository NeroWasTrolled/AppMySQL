using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppMySQL.View;

namespace AppMySQL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageCadastrar());
        }

        private void btnListar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageListar());
        }

        private void btnSair_Clicked(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch (Exception er)
            {
                DisplayAlert("Erro", er.Message, "OK");
            }
        }
    }
}
