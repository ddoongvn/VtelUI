using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace VtelUI.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            CenterBtnCommand = new DelegateCommand(CenterBtnClick);
        }

        private void CenterBtnClick()
        {
            
        }

        public ICommand CenterBtnCommand { get; }
    }
}
