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

            //TableView
            ArticleTableView.EstimatedRowHeight = 50f;
            ArticleTableView.RowHeight = UITableView.AutomaticDimension;

            //Binding
            var set = this.CreateBindingSet<NextViewController, NextViewModel>();
            set.Bind(this).For(v => v.Title).To(vm => vm.Title);
            set.Bind(ArticleTableView).For(v => v.Source).To(vm => vm.Articles);
            set.Apply();
        }
    }

    public class NextTableViewSource : MvxExpandableTableViewSource
    {
        public NextTableViewSource(UITableView tableView) : base(tableView)
        {
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            throw new NotImplementedException();
        }

        protected override UITableViewCell GetOrCreateHeaderCellFor(UITableView tableView, nint section)
        {
            throw new NotImplementedException();
        }
    }
}