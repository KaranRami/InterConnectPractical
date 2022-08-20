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
    public partial class DashboardPage : ContentPage
    {
        private readonly DashboardViewModel _viewModel;
        public DashboardPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new DashboardViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!_viewModel.IsInitialized)
                _ = _viewModel.InitializeAsync().ConfigureAwait(false);
        }
    }
}