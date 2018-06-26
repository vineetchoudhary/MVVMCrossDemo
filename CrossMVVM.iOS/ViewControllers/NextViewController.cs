using Foundation;
using MvvmCross.Platforms.Ios.Views;
using System;
using UIKit;
using CrossMVVM.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace CrossMVVM.iOS
{
    [MvxFromStoryboard("Tip")]
    public partial class NextViewController : MvxViewController<NextViewModel>
    {
        public NextViewController (IntPtr handle) : base (handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<NextViewController, NextViewModel>();
            set.Bind(this).For(v => v.Title).To(vm => vm.Title);
            set.Bind(MainLabel).To(vm => vm.Title);
            set.Apply();
        }
    }
}