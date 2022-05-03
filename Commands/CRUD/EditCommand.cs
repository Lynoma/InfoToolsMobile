using MobileInfoTools.BDD;
using MobileInfoTools.Models;
using MobileInfoTools.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileInfoTools.Commands.CRUD
{
    public class EditCommand : CommandBase
    {
        private readonly EditPageViewModel _vm;

        public EditCommand(EditPageViewModel vm)
        {
            _vm = vm;
        }

        public override void Execute(object parameter)
        {
            bdd.EditRDV(_vm.SelectedItem);
            _vm.NavigateToMainCommand.Execute(null);
        }
    }
}
