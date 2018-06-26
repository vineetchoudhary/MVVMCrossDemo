using CrossMVVM.ViewModels;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using System;
using UIKit;

namespace CrossMVVM.iOS
{
    [MvxFromStoryboard("Tip")]
    public partial class TipDetailViewController : MvxViewController<TipDetailViewModel>
    {
        public TipDetailViewController (IntPtr handle) : base (handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<TipDetailViewController, TipDetailViewModel>();
            set.Bind(SubTotalLabel).To(vm => vm.TipDetails.SubTotal);
            set.Bind(TipLabel).To(vm => vm.TipDetails.TipAmmount);
            set.Bind(TotalLabel).To(vm => vm.TotalAmmount);
            set.Apply();
        }
    }
}