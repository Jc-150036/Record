using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Record
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //画面遷移に必要
            Navigation.PushAsync(new Page());
        }

    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             