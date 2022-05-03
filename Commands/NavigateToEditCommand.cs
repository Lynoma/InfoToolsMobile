using MobileInfoTools.ViewModels;
using MobileInfoTools.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileInfoTools.Commands
{
    public class NavigateToEditCommand : CommandBase
    {
        private Page _app;
        private MainPageViewModel _mainPageViewModel;
        public NavigateToEditCommand(Page app, MainPageViewModel mainPageViewModel)
        {
            _app = app;
            _mainPageViewModel = mainPageViewModel;
        }
        public async override void Execute(object parameter)
        {
            if(_mainPageViewModel.SelectedItem != null)
            {
                await _app.Navigation.PushAsync(new EditPage(_mainPageViewModel.SelectedItem));
                _app.BindingContext = new EditPageViewModel(_mainPageViewModel.SelectedItem, _app);
            }
        }
    }
}
