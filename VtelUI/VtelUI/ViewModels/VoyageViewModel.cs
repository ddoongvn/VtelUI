using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VtelUI.ViewModels
{
    public class VoyageViewModel : ViewModelBase
    {
        public VoyageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
