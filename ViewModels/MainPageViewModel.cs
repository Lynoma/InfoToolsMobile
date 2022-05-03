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
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand NavigateToAddCommand { get; }
        public ICommand NavigateToEditCommand { get; }
        public ICommand DeleteItemCommand { get; }

        private ObservableCollection<RDVModel> _items;
        public ObservableCollection<RDVModel> Items
        {
            get { return _items; }
            set 
            { 
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        private RDVModel _selectedItem;

        public RDVModel SelectedItem
        {
            get { return _selectedItem; }
            set 
            { 
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }


        public MainPageViewModel(Page mainPage)
        {
            Items = new ObservableCollection<RDVModel>();

            Items = bdd.SelectRDVs();
            foreach(RDVModel item in Items)
            {
                item.Client = bdd.SelectSingleClient(item.Client.idC);
                item.Commercial = bdd.SelectSingleCommercial(item.Commercial.idCom);
            }
            NavigateToAddCommand = new NavigateToAddCommand(mainPage, this);
            NavigateToEditCommand = new NavigateToEditCommand(mainPage, this);
            DeleteItemCommand = new DeleteCommand(this);

        }
    }
}
