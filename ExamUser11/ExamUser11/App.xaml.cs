using ExamUser11.Pages;
using ExamUser11.Services;
using ExamUser11.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamUser11
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new RegistrPage();
             
            
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
