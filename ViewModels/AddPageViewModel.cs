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
    public class AddPageViewModel : ViewModelBase
    {
        private RDVModel _newItem;

        public RDVModel NewItem
        {
            get { return _newItem; }
            set 
            { 
                _newItem = value;
                OnPropertyChanged(nameof(_newItem));
            }
        }

        public ObservableCollection<ClientModel> ListClients { get; set; }
        public ObservableCollection<CommercialModel> ListCommerciaux { get; set; }

        public ICommand NavigateToMainCommand { get; }
        public ICommand AddItemCommand { get; }
        public AddPageViewModel(Page app)
        {
            NavigateToMainCommand = new NavigateToMainCommand(app);
            AddItemCommand = new AddCommand(this);

            NewItem = new RDVModel();

            NewItem.DateRDV = DateTime.Now;

            ListClients = bdd.SelectClients();


            ListCommerciaux = bdd.SelectCommerciaux();
            
        }
    }
}
