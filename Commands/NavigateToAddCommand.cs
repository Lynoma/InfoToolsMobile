using MobileInfoTools.ViewModels;
using MobileInfoTools.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileInfoTools.Commands
{
    public class NavigateToAddCommand : CommandBase
    {
        private Page _app;
        private MainPageViewModel _mainPageViewModel;
        public NavigateToAddCommand(Page app, MainPageViewModel mainPageViewModel)
        {
            _app = app;
            _mainPageViewModel = mainPageViewModel;
        }
        public async override void Execute(object parameter)
        {
            await _app.Navigation.PushAsync(new AddPage());
            AddPageViewModel vm = new AddPageViewModel(_app);
            _app.BindingContext = vm;
        }
    }
}
