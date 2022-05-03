using MobileInfoTools.BDD;
using MobileInfoTools.Models;
using MobileInfoTools.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileInfoTools.Commands.CRUD
{
    public class AddCommand : CommandBase
    {
        private readonly AddPageViewModel _vm;

        public AddCommand(AddPageViewModel vm)
        {
            _vm = vm;
        }

        public override void Execute(object parameter)
        {
            bdd.AddRDV(_vm.NewItem);
            _vm.NavigateToMainCommand.Execute(null);
        }
    }
}
