using CrossMVVM.Models.TipDetails;
using CrossMVVM.ViewModels;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using System;
using UIKit;

namespace CrossMVVM.iOS
{
    [MvxFromStoryboard("Tip")]
    public partial class TipViewController : MvxViewController<TipViewModel>
    {
        public TipViewController (IntPtr handle) : base (handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<TipViewController, TipViewModel>();
            set.Bind(this).For(v => v.Title).To(vm => vm.Title);
            set.Bind(TipLabel).To(vm => vm.Tip);
            set.Bind(SubTotalTextField).For(v=>v.Text).To(vm => vm.SubTotal).WithFallback(String.Empty);
            set.Bind(GenerousSlider).To(vm => vm.Generosity);
            set.Bind(NextPageButton).To(vm => vm.MoveToNextPageCommand);
            set.Bind(CommandButton).To(vm => vm.ShowTipDetailsCommand);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.NavigationController?.SetNavigationBarHidden(true, true);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            this.NavigationController?.SetNavigationBarHidden(false, true);
        }
        

        partial void TapGestureRecognized(UITapGestureRecognizer sender)
        {
            SubTotalTextField.ResignFirstResponder();
        }
    }
}