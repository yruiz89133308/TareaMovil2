using TareaFinalPMO2.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TareaFinalPMO2.Model;

namespace TareaFinalPMO2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {

        public Home()
        {
            InitializeComponent();

            OnAppearing();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new ModelView.ListaImagen(Navigation);
        }
        private void menuToolbar_Clicked(object sender, EventArgs e)
        {
        }
    }
}