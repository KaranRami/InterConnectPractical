using InterConnectPractical.Shared.Model;
using InterConnectPractical.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InterConnectPractical.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(ID), "id")]
    public partial class NewsDetailsPage : ContentPage
    {
        private readonly NewsDetailsViewModel _viewModel;
        public NewsDetailsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new NewsDetailsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!_viewModel.IsInitialized)
                _ = _viewModel.InitializeAsync().ConfigureAwait(false);
        }

        public int ID { get; set; }
    }
}