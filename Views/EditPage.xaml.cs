using MobileInfoTools.Models;
using MobileInfoTools.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileInfoTools.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPage : ContentPage
    {
        public EditPage(RDVModel rdv)
        {
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
        }
    }
}