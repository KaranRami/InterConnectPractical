using InterConnectPractical.Resources.Labels;
using InterConnectPractical.Services.Interfaces;
using InterConnectPractical.Shared.Model;
using InterConnectPractical.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Input;
using Xamarin.Forms;

namespace InterConnectPractical.ViewModels
{
    public class NewsDetailsViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly INewsArticleService _newsArticleService = DependencyService.Get<INewsArticleService>();
        private int _id;

        #region Property
        private NewsArticle _newsArticle;
        public NewsArticle NewsArticle
        {
            get { return _newsArticle; }
            set { SetProperty(ref _newsArticle, value); }
        }
        #endregion

        #region Method

        public async Task InitializeAsync()
        {
            try
            {
                NewsArticle = await GetNewsArticleAsync().ConfigureAwait(false);
                IsInitialized = true;
            }
            catch (Exception ex)
            {
                WriteExceptionToLog(ex);
            }
        }

        private async Task<NewsArticle> GetNewsArticleAsync()
        {
            return await _newsArticleService.GetAsync(_id).ConfigureAwait(false);
        }

        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            int.TryParse(HttpUtility.UrlDecode(query["id"]), out _id);
        }
        #endregion
    }
}
