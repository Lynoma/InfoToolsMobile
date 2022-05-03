using MobileInfoTools.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileInfoTools.Commands
{
    public class NavigateToMainCommand : CommandBase
    {
        public Page _app;

        public NavigateToMainCommand(Page app)
        {
            _app = app;
        }
        public async override void Execute(object parameter)
        {
            MainPageViewModel myModel = new MainPageViewModel(_app);
            _app.BindingContext = myModel;
            await _app.Navigation.PopToRootAsync();
        }
    }
}
