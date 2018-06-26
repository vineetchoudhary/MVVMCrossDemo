using CrossMVVM.Models.TipDetails;
using CrossMVVM.Services;
using CrossMVVM.ViewModelResult;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CrossMVVM.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        public string Title { get { return "Tip Calculator"; } }
        private int _subTotal;
        public int SubTotal
        {
            get { return _subTotal; }
            set
            {
                SetProperty(ref _subTotal, value);
                RaisePropertyChanged();
                Recalculate();
            }
        }

        private int _generosity;
        public int Generosity
        {
            get { return _generosity; }
            set
            {
                SetProperty(ref _generosity, value);
                RaisePropertyChanged();
                Recalculate();
            }
        }

        private int _tip;
        public int Tip
        {
            get { return _tip; }
            set
            {
                SetProperty(ref _tip, value);
                RaisePropertyChanged();
            }
        }

        readonly ICalculationService _calculationService;
        readonly IMvxNavigationService _mvxNavigationService;
        public IMvxCommand MoveToNextPageCommand { get; private set; }
        public IMvxCommand<ITipDetails> ShowTipDetailsCommand { get; private set; }

        public TipViewModel(ICalculationService calculationService, IMvxNavigationService mvxNavigationService)
        {
            _calculationService = calculationService;
            _mvxNavigationService = mvxNavigationService;
            MoveToNextPageCommand = new MvxAsyncCommand(() => MoveToNextPage());
            ShowTipDetailsCommand = new MvxAsyncCommand<ITipDetails>(ShowTipDetails);
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            _subTotal = 100;
            _generosity = 10;
            Recalculate();
        }

        private void Recalculate()
        {
            Tip = _calculationService.TipAmmount(SubTotal, Generosity);
        }

        private async Task MoveToNextPage()
        {
            await _mvxNavigationService.Navigate<NextViewModel>();
        }

        private async Task ShowTipDetails(ITipDetails tipDetails)
        {
            var tipDetail = new TipDetails
            {
                TipAmmount = Tip,
                SubTotal = SubTotal
            };
            await _mvxNavigationService.Navigate<TipDetailViewModel, ITipDetails>(tipDetail);
        }
    }
}
