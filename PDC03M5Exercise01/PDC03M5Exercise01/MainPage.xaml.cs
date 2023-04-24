using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03M5Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Exercise01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exercise01());
        }

        private async void Exercise01Picker(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new exercise01picker());
        }
    }
}
