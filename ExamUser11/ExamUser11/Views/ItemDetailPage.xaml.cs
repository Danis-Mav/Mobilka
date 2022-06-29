using ExamUser11.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ExamUser11.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}