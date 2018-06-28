/*
 * 
 * Created By Vineet Choudhary
 * Nuget Dependencies - MVVMCross
 * 
 */

using System;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.ViewModels;

namespace Common.iOS
{
    public class BaseViewController<TViewModel> : MvxViewController<TViewModel> where TViewModel : class, IMvxViewModel
    {
        protected Loader _loader;
        public BaseViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _loader = new Loader(View);
        }
    }
}