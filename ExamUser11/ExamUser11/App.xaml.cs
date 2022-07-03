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
        public const string DATABASE_NAME = "project.db";
        public static ProjectRepository database;
        public static ProjectRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new ProjectRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

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
