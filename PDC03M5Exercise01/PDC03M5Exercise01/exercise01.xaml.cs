using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03M5Exercise01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class exercise01 : ContentPage
    {
        public exercise01()
        {
            InitializeComponent();
        }

        private void OnToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                // Switch is toggled on
            }
            else
            {
                // Switch is toggled off
            }
        }
    }
}