using MobileInfoTools.BDD;
using MobileInfoTools.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileInfoTools.Commands.CRUD
{
    public class DeleteCommand : CommandBase
    {
        private readonly MainPageViewModel _mainPageViewModel;

        public DeleteCommand(MainPageViewModel mainPageViewModel)
        {
            _mainPageViewModel = mainPageViewModel;
        }

        public override void Execute(object parameter)
        {
            if(_mainPageViewModel.SelectedItem != null)
            {
                _mainPageViewModel.Items.Remove(_mainPageViewModel.SelectedItem);
                bdd.DeleteRDV(_mainPageViewModel.SelectedItem.IdRDV);
            }
        }
    }
}
