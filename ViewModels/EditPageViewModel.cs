using MobileInfoTools.BDD;
using MobileInfoTools.Commands;
using MobileInfoTools.Commands.CRUD;
using MobileInfoTools.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileInfoTools.ViewModels
{
    public class EditPageViewModel : ViewModelBase
    {
        public ICommand NavigateToMainCommand { get; }
        public ICommand EditItemCommand { get; }

        public ObservableCollection<CommercialModel> ListCommerciaux { get; set; }
        public ObservableCollection<ClientModel> ListClients { get; set; }


        private RDVModel _selectedItem;

        public RDVModel SelectedItem
        {
            get { return _selectedItem; }
            set 
            { 
                _selectedItem = value;
                OnPropertyChanged(nameof(_selectedItem));
            }
        }

        public EditPageViewModel(RDVModel selectedItem, Page app)
        {
            SelectedItem = selectedItem;

            EditItemCommand = new EditCommand(this);

            NavigateToMainCommand = new NavigateToMainCommand(app);

            ListClients = bdd.SelectClients();

            ListCommerciaux = bdd.SelectCommerciaux();

            Console.WriteLine("Bonjour");
        }
    }
}
