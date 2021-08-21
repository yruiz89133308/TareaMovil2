using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TareaFinalPMO2.ModelView;

namespace TareaFinalPMO2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inform : ContentPage
    {
        public Inform()
        {
            InitializeComponent();
            BindingContext = new PersonasView();
        }
    }
}