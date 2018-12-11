using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOADLab2.Models;
using OOADLab2.ViewModels;
using Xamarin.Forms;

namespace OOADLab2
{
    public partial class MainPage : ContentPage
    {

        private MainViewModel MainViewModel;
        public MainPage()
        {

            MainViewModel = new MainViewModel();

            this.BindingContext = MainViewModel;

            InitializeComponent();
        }

        private void ButtonClicked()
        {
            MainViewModel.MvButtonClicked();
        }
    }
}
