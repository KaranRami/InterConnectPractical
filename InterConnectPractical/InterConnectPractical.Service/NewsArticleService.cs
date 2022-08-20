using InterConnectPractical.Services.Interfaces;
using InterConnectPractical.Shared.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterConnectPractical.Service
{
    public class NewsArticleService : INewsArticleService
    {
        private const string _dummyText = "Please be aware of the following changes to school timings  and protocols";
        private const string _dummyTextArabic = "يرجى الانتباه إلى التغييرات التالية في أوقات المدرسة والبروتوكولات";

        private readonly IEnumerable<NewsArticle> _newsArticles = new List<NewsArticle>()
            {
                new NewsArticle(){ Date = DateTime.Now, Description = _dummyText, Title = _dummyText, ImageURL = "Dummy.JPG", ID =0},
                new NewsArticle(){ Date = DateTime.Now, Description = _dummyTextArabic, Title = _dummyTextArabic, ImageURL = "Dummy.JPG", ID =1, IsRtlFlowDirection = true},
                new NewsArticle(){ Date = DateTime.Now, Description = _dummyText, Title = _dummyText , ImageURL = "Dummy.JPG", ID =2},
                new NewsArticle(){ Date = DateTime.Now, Description = _dummyTextArabic, Title = _dummyTextArabic, ImageURL = "Dummy.JPG", ID =3, IsRtlFlowDirection = true},
            };

        public async Task<IEnumerable<NewsArticle>> GetAllAsync()
        {
            return await Task.FromResult(_newsArticles);
        }

        public async Task<NewsArticle> GetAsync(int id)
        {
            NewsArticle newsArticle = _newsArticles.FirstOrDefault(n => n.ID == id);
            return await Task.FromResult(newsArticle);
        }
    }
}
