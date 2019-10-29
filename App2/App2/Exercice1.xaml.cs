using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercice1 : ContentPage
    {
        public Exercice1()
        {
            InitializeComponent();
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    mylayout.Padding = new Thickness(20, 30, 20, 20);
                    break;
                case Device.UWP:
                    mylayout.Padding = new Thickness(20, 40, 20, 20);
                    break;
            }
        }
    }
}