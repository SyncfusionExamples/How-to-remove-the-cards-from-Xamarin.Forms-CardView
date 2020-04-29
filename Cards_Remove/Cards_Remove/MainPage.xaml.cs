using Syncfusion.XForms.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Cards_Remove
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
        }

        private void SfCardView_Dismissed(object sender, DismissedEventArgs e)
        {
            var item = (sender as SfCardView).BindingContext as CardModel;

            var items = (this.BindingContext as CardViewModel).Items;
            if (items.Contains(item))
            {
                items.Remove(item);
            }
        }
    }
}
