using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prototype2.View.Dialogs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ErrorDialog : ContentPage
    {
        public ErrorDialog()
        {
            InitializeComponent();
        }
    }
}