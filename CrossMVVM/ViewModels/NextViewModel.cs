using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace CrossMVVM.ViewModels
{
    public class NextViewModel : MvxViewModel
    {
        public string Title { get { return "Next"; } }

        public IMvxNavigationService _mvxNavigationService;

        public override async Task Initialize()
        {
            await base.Initialize();
        }

        public NextViewModel(IMvxNavigationService mvxNavigationService)
        {
            _mvxNavigationService = mvxNavigationService;
        }
    }
}
