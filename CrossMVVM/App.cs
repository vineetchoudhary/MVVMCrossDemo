using CrossMVVM.Services;
using CrossMVVM.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossMVVM
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<ICalculationService, CalculationService>();
            RegisterAppStart<TipViewModel>();
        }
    }
}
