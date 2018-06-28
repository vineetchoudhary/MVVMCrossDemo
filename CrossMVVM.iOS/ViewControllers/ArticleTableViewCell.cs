using CrossMVVM.Models;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using System;
using UIKit;

namespace CrossMVVM.iOS
{
    //[MvxFromStoryboard("Tip")]
    public partial class ArticleTableViewCell : MvxTableViewCell
    {
        public ArticleTableViewCell(IntPtr handle) : base(handle)
        {
            
        }
        
        public void ConfigCell(Article article)
        {
            TitleLabel.Text = article.Title;
            ContentLabel.Text = article.Content;
        }
        
        
    }
}