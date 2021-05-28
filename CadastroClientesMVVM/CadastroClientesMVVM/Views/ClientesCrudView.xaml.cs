using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadastroClientesMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientesCrudView : ContentPage
    {
        public ClientesCrudView()
        {
            InitializeComponent();            
        }
    }
}