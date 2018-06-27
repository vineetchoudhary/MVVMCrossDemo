using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common.RestClient;
using CrossMVVM.Models;
using CrossMVVM.Services;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace CrossMVVM.ViewModels
{
    public class NextViewModel : MvxViewModel
    {
        private MvxObservableCollection<Article> _articles = null;
        public string Title { get { return "Articles"; } }
        public readonly ArticleService ArticleService = new ArticleService();
        public MvxObservableCollection<Article> Articles
        {
            get => _articles;
            private set
            {
                if (SetProperty(ref _articles, value))
                    RaisePropertyChanged();
            }
        }

        public IMvxNavigationService _mvxNavigationService;

        public override async Task Initialize()
        {
            await base.Initialize();
            var articles = await ArticleService.GetArticlesAsync();
            if (articles != null)
                Articles = new MvxObservableCollection<Article>(articles);
        }

        public NextViewModel(IMvxNavigationService mvxNavigationService)
        {
            _mvxNavigationService = mvxNavigationService;
        }
    }
}
