using CrossMVVM.Models;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using System;
using UIKit;

namespace CrossMVVM.iOS
{
    public partial class ArticleTableViewCell : MvxTableViewCell
    {
        public ArticleTableViewCell(IntPtr handle) : base(handle)
        {
            
        }
        
        public void ConfigCell(Article article)
        {
            this.DelayBind(() => { this.AddBindings(TitleLabel, "This Text"); });
            this.DelayBind(() => { this.AddBindings(ContentLabel, "This Text"); });
        }
        
        
    }
}