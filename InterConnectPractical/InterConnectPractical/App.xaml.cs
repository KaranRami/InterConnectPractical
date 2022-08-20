using InterConnectPractical.Service;
using InterConnectPractical.Services.Interfaces;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterConnectPractical
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            RegisterDependecies();
        }

        private void RegisterDependecies()
        {
            DependencyService.Register<INewsArticleService, NewsArticleService>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
