using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CrossMVVM.Models.TipDetails;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace CrossMVVM.ViewModels
{
    public class TipDetailViewModel : MvxViewModel<ITipDetails>
    {

        public ITipDetails TipDetails { get; private set; }
        public int TotalAmmount { get => TipDetails.SubTotal + TipDetails.TipAmmount; }

        readonly IMvxNavigationService _mvxNavigationService;
        public TipDetailViewModel(IMvxNavigationService mvxNavigationService)
        {
            _mvxNavigationService = mvxNavigationService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();
        }

        public override void Prepare(ITipDetails parameter)
        {
            TipDetails = parameter;
        }
    }
}
