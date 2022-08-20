using InterConnectPractical.Resources.Labels;
using InterConnectPractical.Services.Interfaces;
using InterConnectPractical.Shared.Model;
using InterConnectPractical.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterConnectPractical.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        private readonly INewsArticleService _newsArticleService = DependencyService.Get<INewsArticleService>();

        #region Property
        private ObservableRangeCollection<NewsArticle> _newsArticles = new ObservableRangeCollection<NewsArticle>();
        public ObservableRangeCollection<NewsArticle> NewsArticles
        {
            get { return _newsArticles; }
            set { SetProperty(ref _newsArticles, value); }
        }
        #endregion

        #region Method

        public async Task InitializeAsync()
        {
            try
            {
                IEnumerable<NewsArticle> newsArticles = await GetNewsArticlesAsync().ConfigureAwait(false);
                NewsArticles.AddRange(newsArticles);
                IsInitialized = true;
            }
            catch (Exception ex)
            {
                WriteExceptionToLog(ex);
            }
        }

        private async Task<IEnumerable<NewsArticle>> GetNewsArticlesAsync()
        {
            return await _newsArticleService.GetAllAsync();
        }
        #endregion

        #region Command
        public ICommand NewsArticleSelectedCommand { get { return new Command<NewsArticle>(async (NewsArticle newsArticle) => await ShowNewArticleDetailsAsync(newsArticle)); } }
        private async Task ShowNewArticleDetailsAsync(NewsArticle newsArticle)
        {
            //await Shell.Current.Navigation.PushAsync(new NewsDetailsPage(newsArticle)).ConfigureAwait(false);
            await Shell.Current.GoToAsync($"{AppTitles.PageTitleNewsDetails}?id={newsArticle.ID}").ConfigureAwait(false);
        }
        #endregion
    }
}
