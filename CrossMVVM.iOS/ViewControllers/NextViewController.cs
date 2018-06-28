using Foundation;
using MvvmCross.Platforms.Ios.Views;
using System;
using UIKit;
using CrossMVVM.ViewModels;
using MvvmCross.Binding.BindingContext;
using CrossMVVM.Models;
using MvvmCross.Platforms.Ios.Binding.Views;
using Common.iOS;
using Common.RestClient;

namespace CrossMVVM.iOS
{
    [MvxFromStoryboard("Tip")]
    public partial class NextViewController : BaseViewController<NextViewModel>
    {
        private NextTableViewSource _nextTableViewSource;
        
        public NextViewController (IntPtr handle) : base (handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //TableView
            ArticleTableView.EstimatedRowHeight = 50f;
            ArticleTableView.RowHeight = UITableView.AutomaticDimension;

            _nextTableViewSource = new NextTableViewSource(ArticleTableView);
            ArticleTableView.Source = _nextTableViewSource;

            //Binding
            var set = this.CreateBindingSet<NextViewController, NextViewModel>();
            set.Bind(this).For(v => v.Title).To(vm => vm.Title);
            set.Bind(_nextTableViewSource).For(v => v.ItemsSource).To(vm => vm.Articles);
            set.Bind(_loader).For(v => v.Show).To(vm => vm.IsBusy);
            set.Apply();
        }
    }

    public class NextTableViewSource : MvxTableViewSource
    {
        public NextTableViewSource(UITableView tableView) : base(tableView)
        {
            //tableView.RegisterClassForCellReuse(typeof(ArticleTableViewCell), nameof(ArticleTableViewCell));
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            var cell = tableView.DequeueReusableCell(nameof(ArticleTableViewCell), indexPath) as ArticleTableViewCell;
            cell.ConfigCell(item as Article);
            return cell;
        }
    }
}