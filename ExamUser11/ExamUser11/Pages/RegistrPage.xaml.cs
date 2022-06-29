using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamUser11.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrPage : ContentPage
    {
        int count = 0;
        int count1 = 0;
        public RegistrPage()
        {
            InitializeComponent();
            
        }
        private void GlazBut1Cl(object sender, EventArgs e)
        {
            count++;
            if (count%2 == 1)
            {
                Password.IsPassword = false;
            }
            else Password.IsPassword = true;
        }
        private void GlazBut2Cl(object sender, EventArgs e)
        {
            count1++;
            if (count1 % 2 == 1)
            {
                Password2.IsPassword = false;
            }
            else Password2.IsPassword = true;
        }

        private void RegBut_Clicked(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Password.Text);
            if (a > 999)
            {
            if (Password2 == Password)
            {
                //ExamUser11.Data.DataAccess.SavePass(Name.Text);
                Navigation.PushAsync(new AuthoPage());
            }
            else warning2.IsVisible = true;
            }
            else warning.IsVisible = true;

        }
      
    }
}